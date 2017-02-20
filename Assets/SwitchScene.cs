﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
	public string sceneName;
	
	public void StartGame()
	{
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}
}
