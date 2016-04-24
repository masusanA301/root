using UnityEngine;
using System.Collections;

public class GameSceneManager : SingletonMonoBehaviour<GameSceneManager> {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// ホームシーンに戻る
    /// </summary>
    public void ExitFromGame()
    {
        Application.LoadLevel("Home");
        //TODO:このままだとタイトルシーンにいくので要調整
    }
}
