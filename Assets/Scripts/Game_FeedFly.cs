using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
           
public class Game_FeedFly : MonoBehaviour {

	public GameObject goFly;
	public GameObject goBee;
	public GameObject goTimer;
	public GameObject goProgress;

	public int FliesNeeded = 5;
	public int nFlies = 10;
	public int nBees = 10;
	public int FlyCount = 0;


	private Text txtTimer;
	private float timer = 0;
	public int maxTime = 5;

	public Slider progress;

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
			Instantiate(goFly, new Vector3(Random.RandomRange(-6, 6), Random.RandomRange(-4, 4), 0), Quaternion.Euler(0, 0, 0) );
	
		for (int n = 0; n < nBees; n++)
			Instantiate(goBee, new Vector3(Random.RandomRange(-6, 6), Random.RandomRange(-4, 4), 0), Quaternion.Euler(0, 0, 0));


		txtTimer = goTimer.GetComponent<Text>();

		progress = goProgress.GetComponent<Slider>();
		progress.maxValue = FliesNeeded;
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;
		int t = System.Convert.ToInt32(timer % 60);

		if (t <= maxTime)
		{
			txtTimer.text = "Time: " + (maxTime - t);
		}
		else
		{
			// gameOver
		}
			
	}
}
