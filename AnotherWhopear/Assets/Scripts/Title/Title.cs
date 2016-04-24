using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

    private GameObject StageSelect;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void OnClickStageSelect()
    {
        HomeSceneManager.Instance.ChangeScene(HomeSceneManager.SCENES.STAGESELECT);
    }
}
