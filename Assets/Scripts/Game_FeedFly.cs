using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_FeedFly : MonoBehaviour {

	public GameObject goFly;
	public GameObject goBee;

	// Use this for initialization
	void Start () {
		
		int nFlies = 5;

		// instantiate flies
		for (int n = 0; n < nFlies; n++)
        {
			Instantiate(goFly, new Vector3(Random.RandomRange(-3, 5), Random.RandomRange(-3, 5), 0), Quaternion.Euler(0, 0, 0) );
			Instantiate(goBee, new Vector3(Random.RandomRange(-3, 5), Random.RandomRange(-3, 5), 0), Quaternion.Euler(0, 0, 0) );
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
