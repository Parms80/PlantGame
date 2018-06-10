using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterTimer : MonoBehaviour {

	private Text txtTimer;
	private float timer = 0;
	public int maxTime = 5;
	public GameObject sunnyBackground;
	private SpriteRenderer backgroundImage;

	void Start () {
		txtTimer = GetComponent<Text>();
		backgroundImage = sunnyBackground.GetComponent<SpriteRenderer> ();		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		int t = System.Convert.ToInt32(timer % 60);

		if (t <= maxTime)
		{
			txtTimer.text = "Time: " + (maxTime - t);
		}
		else
		{
			// gameOver
		}
		fadeInSunnyBackground (t);
	}

	void fadeInSunnyBackground(int t) {
		float alpha = 1 - (maxTime-t)/maxTime;
		Debug.Log ("t = " + t+ ", alpha = "+alpha);

		backgroundImage.color = new Color(backgroundImage.color.r, 
										  backgroundImage.color.g, 
										  backgroundImage.color.b, 
										  alpha);
	}
}
