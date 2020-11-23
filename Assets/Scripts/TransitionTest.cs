using System.Collections;
using UnityEngine;
using System.Timers;
using UnityEngine.UI; //テキスト使うなら必要

public class TransitionTest : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public int randomNum = 0;
    public string NumID;

    public float countTime = 0.0f;
    private float span  = 3.0f;  
    private float idleSpan  = 1.5f;  

    public bool idleflag = false;


    public Text countTimeText;

    public void Start(){
        
        Time.timeScale = 1.0f;
        GameObject countTimeTextObj = GameObject.Find("countTime");
        
        countTimeText = countTimeTextObj.GetComponentInChildren<Text>();

    }

    private IEnumerator  ChangeCharaState()
    {
        Debug.Log("hoge");

        idleflag = !idleflag;

        randomNum = UnityEngine.Random.Range(0, 7);

        NumID = randomNum.ToString();
        
        //秒待つ
//        yield return new WaitForSeconds(0.5f);
        //Idle -> SampleAnimation1 に遷移
        _animator.CrossFadeInFixedTime("armature|anm_kmhh_" +(NumID.PadLeft(3,'0'))+"_in", 0.25f);
        Debug.Log("armature|anm_kmhh_" +(NumID.PadLeft(3,'0'))+"_in");
        //秒待つ
        yield return  new WaitForSeconds(0.5f);
        _animator.CrossFadeInFixedTime("armature|anm_kmhh_" +(NumID.PadLeft(3,'0'))+"_lp", 0);

        Debug.Log("armature|anm_kmhh_" +(NumID.PadLeft(3,'0'))+"_lp");

        //1秒待つ
        //yield return new WaitForSeconds(0);

        //SampleAnimation1 -> SampleAnimation2　に遷移


        //_animator.CrossFadeInFixedTime("armature|anm_kmhh_000_lp", 0);
        
        
        //Time.timeScale += 0.5f;

    }

    private IEnumerator  ChangeCharaStateToIdle()
    {

        idleflag = !idleflag;


        randomNum = UnityEngine.Random.Range(0, 2);

        NumID = randomNum.ToString();

        yield return new WaitForSeconds(0f);
        _animator.CrossFadeInFixedTime("armature|anm_kmhh_idle_" +(NumID.PadLeft(3,'0')), 0.25f);
        Debug.Log("armature|Poses");


        
    }

    public void Update()
    {

        countTime += Time.deltaTime;

        //Debug.Log(countTime);

        if((countTime > idleSpan) && (idleflag == false)){

            StartCoroutine("ChangeCharaState");
            Debug.Log(countTime);

            countTime = 0f;
            
            }
        else if((countTime > span) && (idleflag == true)){
            
            StartCoroutine("ChangeCharaStateToIdle");

            countTime = 0f;
        }
        
        countTimeText.text = countTime.ToString("f1");

    }
}