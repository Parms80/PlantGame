using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_FeedFly : MonoBehaviour {

	public GameObject goFly;
	public GameObject goBee;

	public int FliesNeeded = 5;
	public int nFlies = 10;
	public int nBees = 10;
	public int FlyCount = 0;

	public void intGame(int needed, int flies, int bees)
	{
		FliesNeeded = needed;
		nFlies = flies;
		nBees = bees;

		FlyCount = 0;
	}

	// Use this for initialization
	void Start () {
		
		// instantiate flies
		for (int n = 0; n < nFlies; n++)
			Instantiate(goBee, new Vector3(Random.RandomRange(-3, 5), Random.RandomRange(-3, 5), 0), Quaternion.Euler(0, 0, 0) );
	
		for (int n = 0; n < nBees; n++)
			Instantiate(goBee, new Vector3(Random.RandomRange(-3, 5), Random.RandomRange(-3, 5), 0), Quaternion.Euler(0, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
