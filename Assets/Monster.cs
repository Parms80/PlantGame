using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	public float closeMouthDelay = 2;
	private SpriteRenderer monsterSprite; 
	private Animator animator;

	// Use this for initialization
	void Start () {
		monsterSprite = GetComponent<SpriteRenderer> ();
		animator = GetComponent<Animator> ();
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
}
