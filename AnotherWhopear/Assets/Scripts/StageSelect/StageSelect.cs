﻿using UnityEngine;
using System.Collections;

public class StageSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClickToGameScene()
    {
        HomeSceneManager.Instance.GoToGame();
    }
}
