using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public GameObject sunnyBackground;
	public float levelSeconds;
	public Text timeOverText;
	private Slider slider;
	private SpriteRenderer backgroundImage;

	// Use this for initialization
	void Start () {
		slider = GetComponent<Slider> ();
		backgroundImage = sunnyBackground.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		backgroundImage.color = new Color(backgroundImage.color.r, backgroundImage.color.g, backgroundImage.color.b, slider.value);

		if (slider.value == 1) {
			timeOverText.gameObject.SetActive(true);
		}
	}
}
