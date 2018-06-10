using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaterTimer : MonoBehaviour {

	private Text txtTimer;
	private float timer = 0;
	public int maxTime = 5;
	public GameObject sunnyBackground;
	private SpriteRenderer backgroundImage;
	public Text timeOverText;
	public int stage = 1;

	void Start () {
		Global.curStage = stage;
		txtTimer = GetComponent<Text>();
		backgroundImage = sunnyBackground.GetComponent<SpriteRenderer> ();		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		float alpha = 1 - (maxTime-timer)/maxTime;
				Debug.Log ("timer = " + timer+ ", alpha = "+alpha);
		int t = System.Convert.ToInt32(timer % 60);

		if (t <= maxTime)
		{
			txtTimer.text = "Time: " + (maxTime - t);
			fadeInSunnyBackground (alpha);
		}
		else
		{
			timeOverText.gameObject.SetActive (true);
			StartCoroutine(LoadGameOver());
		}
	}

	void fadeInSunnyBackground(float alpha) {
//		float alpha = 1 - (maxTime-t)/maxTime;
//		Debug.Log ("t = " + t+ ", alpha = "+alpha);

		backgroundImage.color = new Color(backgroundImage.color.r, 
										  backgroundImage.color.g, 
										  backgroundImage.color.b, 
										  alpha);
	}

	IEnumerator LoadGameOver()
	{
		yield return new WaitForSeconds(2);
		SceneManager.LoadScene ("_GameOver");
	}
}
