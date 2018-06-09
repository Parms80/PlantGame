using System.Collections;
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

		transform.Translate(x, y , 0);
	}

	void OnMouseDown()
    {
		Debug.Log("Fly Clicked " + this.name);

		this.gameObject.SetActive(false);
		Destroy(this);
    }

}
