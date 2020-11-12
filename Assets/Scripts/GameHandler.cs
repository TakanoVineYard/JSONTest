﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
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

CharaInfo loadedCharaData = JsonUtility.FromJson<CharaInfo>(jsonChara);

Debug.Log("id:"+ loadedCharaData.id[0]);
Debug.Log("categoryA:"+ loadedCharaData.categoryA[0]);
Debug.Log("categoryB:"+ loadedCharaData.categoryB[0]);

    }

    
//テストキャラ情報のクラス  
    private class CharaInfo{
    public string[] id;
    public string[] categoryA;
    public string[] categoryB;
    public string[] categoryC;
    public string[] categoryD;


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

