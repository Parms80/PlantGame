using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevelAfter;

	void Start() {
		if (autoLoadNextLevelAfter <= 0) {
			Debug.Log ("Level auto load disabled. Use a positive number in seconds");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene (name);
	}

	public void LoadLevelStage(){
		Debug.Log ("LoadLevelStage: " + Global.curStage);

		switch (Global.curStage) {
		case 0:
			SceneManager.LoadScene ("_MainMenu");
			break;
		case 1:
			SceneManager.LoadScene ("Watering");
			break;
		}
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene (Application.loadedLevel + 1);
	}
}
