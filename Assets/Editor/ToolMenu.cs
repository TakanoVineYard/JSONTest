using UnityEditor;
using UnityEngine;

public class ToolMenu {

    #region JSONの動作テスト
    [MenuItem("Tool/Json Test")]
    static void JsonTest()
    {
        PlayerInfo pi = PlayerInfo.CreateFromJSON("{\"name\":\"Dr Charles\", \"lives\":3,\"health\":0.8}");
        Debug.Log("pi.name = " + pi.name);
        Debug.Log("pi.lives = " + pi.lives);
        Debug.Log("pi.health = " + pi.health);
    }
    #endregion
}