using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		mousePosition.z = 0f;
		transform.position = mousePosition;//Vector2.Lerp(transform.position, mousePosition, moveSpeed);
	}
}
