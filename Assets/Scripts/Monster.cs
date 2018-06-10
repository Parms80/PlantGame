using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour {

	public Transform flies;
	public Text ouchText;
	public float closeMouthDelay = 2;
	private Animator animator;
	public bool closedMouth;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		closedMouth = false;
		ouchText.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (isTimeToCloseMouth()) {
			CloseMouth();
		}
	}

	bool isTimeToCloseMouth () {
		float shutsPerSecond = 1 / closeMouthDelay;

		if (Time.deltaTime > closeMouthDelay) {
			Debug.LogWarning ("Spawn rate capped by frame rate");
		}

		float threshold = shutsPerSecond * Time.deltaTime / 5;

		return (Random.value < threshold);
	}

	void CloseMouth(){
		animator.SetTrigger ("closeMouthTrigger");
	}

	public void HideFlies(){
		foreach (Transform fly in flies) {
			fly.gameObject.SetActive (false);
		}
		closedMouth = true;
	}

	public void ShowFlies(){
		foreach (Transform fly in flies) {
			fly.gameObject.SetActive (true);
		}
		closedMouth = false;
	}

	void OnTriggerStay2D(Collider2D other) {
		if (closedMouth) {
			ouchText.gameObject.SetActive (true);
		}
	}
}
