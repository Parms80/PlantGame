﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	float speed = 3;

	// Update is called once per frame
	void Update () {

		float x = speed * Time.deltaTime * Random.RandomRange(-speed, speed);
		float y = speed * Time.deltaTime * Random.RandomRange(-speed, speed);

		int xbounds = 2;
		int ybounds = 2;

		transform.Translate(x, y, 0);

		/*if (this.transform.localPosition.x > -xbounds &&
			this.transform.localPosition.x < xbounds)
			transform.Translate(x, 0, 0);

		if (this.transform.localPosition.y > -ybounds &&
            this.transform.localPosition.y < ybounds)
            transform.Translate(0, y, 0);
		*/
	}

	void OnMouseDown()
    {
		Debug.Log("Fly Clicked " + this.name);

		this.gameObject.SetActive(false);
		Destroy(this);
    }

}
