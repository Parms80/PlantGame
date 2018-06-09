using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BucketMeter : MonoBehaviour {

	public Slider slider;
	public Bucket bucket;

	// Use this for initialization
	void Start () {
		slider.maxValue = bucket.dripsUntilFull;
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = Mathf.MoveTowards(slider.value, bucket.numDripsCaught, 0.15f);
	}
}
