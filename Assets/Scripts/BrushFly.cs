using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushFly : MonoBehaviour {

	private float opacity = 1f;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}

	void OnTriggerStay2D() {
		fadeFly ();
	}

	void fadeFly() {
		opacity -= 0.01f;
		spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, opacity);
		if (opacity <= 0) {
			gameObject.SetActive (false);
		}
	}
}
