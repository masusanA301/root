/// <summary>
/// シーン管理クラス
/// </summary>


using UnityEngine;
using System.Collections;

public class HomeSceneManager : SingletonMonoBehaviour<HomeSceneManager> {

    public enum SCENES
    {
        TITLE,
        STAGESELECT,
        NUM,
    };

    private GameObject[] scenes = new GameObject[(int)SCENES.NUM];
    private SCENES currentScene = SCENES.TITLE;

	// Use this for initialization
	void Start () {
        GameObject canvas = GameObject.Find("Canvas");
        scenes[(int)SCENES.TITLE] = canvas.transform.FindChild("Title").gameObject;
        scenes[(int)SCENES.STAGESELECT] = canvas.transform.FindChild("StageSelect").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// シーン遷移関数
    /// ゲームシーンとの行き来は別
    /// TODO:フェード処理はまだいれていないので後で入れる
    /// </summary>
    /// <param name="nextSceneGameObject"></param>
    public void ChangeScene(SCENES nextScene)
    {
        scenes[(int)currentScene].SetActive(false);
        scenes[(int)nextScene].SetActive(true);
        currentScene = nextScene;
    }
    /// <summary>
    /// ゲームシーンへ行く
    /// </summary>
    public void GoToGame()
    {
        Application.LoadLevel("Game");
    }
}
