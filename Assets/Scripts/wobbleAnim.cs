using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wobbleAnim : MonoBehaviour {

	// Use this for initialization
	void Start () {

		iTween.ScaleBy(this.gameObject, iTween.Hash(
			"x", 1.05, 
			"z", 1.05, 
			"default", .2,
			"easeType",
            "easeInOutExpo",
			"loopType", "pingPong"
		));
       /* this
		iTween.ScaleBy(this.gameObject, iTween.Hash("y",
                                                   4,
                                                   "easeType",
                                                   "easeInOutExpo",
                                                   "loopType",
                                                   "pingPong",
                                                   "delay",
                                                   .01
                                                  )
                     );*/
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
