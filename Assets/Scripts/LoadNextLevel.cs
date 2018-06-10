﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour {

	public string nextLevel;

	void Start () {

		StartCoroutine(LoadNextStage());
	}

	IEnumerator LoadNextStage()
	{
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene (nextLevel);
	}
}
