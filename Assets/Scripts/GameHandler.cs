using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class GameHandler : MonoBehaviour
{
    
public int randomNum;


    // Start is called before the first frame update
    private void Start()
    {

        randomNum = UnityEngine.Random.Range(0, 7);

     Debug.Log("GameHandler.Start");   
/*
//プレイヤー情報クラスの継承と代入
     PlayerData PlayerData = new PlayerData();
     PlayerData.position = new Vector3(5,0);
     PlayerData.health = 80;

//JSON文字列形式にする
     string json = JsonUtility.ToJson(PlayerData);
     //Debug.Log(json);


//ファイルに保存
    Debug.Log(Application.dataPath);
    File.WriteAllText((Application.dataPath + "saveFile.json"), json);
*/


//ファイルのロード
//string json  = File.ReadAllText(Application.dataPath + "/saveFile.json");
//PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(json);
//JSON文字列を要素ごとに分解
    //PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(json);
    //Debug.Log("position: "+loadedPlayerData.position);
    //Debug.Log("health: "+loadedPlayerData.health);




//ファイルのロード（テストの方）
string jsonChara = File.ReadAllText(Application.dataPath + "/Resources/JsonTestData.json");
Debug.Log(jsonChara);

//CharaInfo loadedCharaData = JsonUtility.FromJson<CharaInfo>(jsonChara);

CharacterInfoAll infoAll = JsonUtility.FromJson<CharacterInfoAll>(jsonChara);

//Debug.Log(infoAll.infoArray[0].id);



Debug.Log("id:"+ infoAll.infoArray[randomNum].id);
Debug.Log("categoryA:"+ infoAll.infoArray[randomNum].categoryA);
Debug.Log("categoryB:"+ infoAll.infoArray[randomNum].categoryB);




//Debug.Log("id:"+ infoAll.infoArray[1].id);
//Debug.Log("categoryA:"+ infoAll.infoArray[1].categoryA);
//Debug.Log("categoryB:"+ infoAll.infoArray[1].categoryB);

    }
    
//テストキャラ情報のクラス  
[System.Serializable]
    public class CharacterInfo{
    public string id;
    public string categoryA;
    public string categoryB;
    public string categoryC;
    public string categoryD;


    }


[System.Serializable]
public class CharacterInfoAll
{
    public CharacterInfo[] infoArray;
}


/*
{
	"CharaInfo": [
			{
				"id": "0000",
				"categoryA": "Hoge",
				"categoryB": "Nya",
				"categoryC": "Wan",
				"categoryD": "Pu"
			},
            {.........
*/



    
//プレイヤー情報のクラス
    private class PlayerData{
     public Vector3 position;
     public int health;   
    }

}

