using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bucket : MonoBehaviour {

	public float moveSpeed = 1;
	public int numDripsCaught = 0;
	public int dripsUntilFull = 10;
	public Text bucketFullText;
	private bool moveLeft = false;
	private bool moveRight = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateBucket();
	}

	void UpdateBucket() {
		if (moveLeft) {
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
		} else if (moveRight) {
			transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);
		}
	}

	public void LeftButtonPressed() {
		moveLeft = true;
	}
	public void LeftButtonReleased() {
		moveLeft = false;
	}
	public void RightButtonPressed() {
		moveRight = true;
	}
	public void RightButtonReleased() {
		moveRight = false;
	}

	void OnParticleCollision(GameObject other) {
		numDripsCaught++;

		if (numDripsCaught == dripsUntilFull) {
			bucketFullText.gameObject.SetActive(true);
		}
	}
}
