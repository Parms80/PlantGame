using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighbourObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnMouseDown()
	{
		//.SetActive(false);

		iTween.Stop(this.gameObject);

		iTween.RotateBy(this.gameObject, iTween.Hash("y",
                                                   2,
                                                   "easeType",
                                                   "easeInOutExpo",
                                                   //"loopType",
                                                   //"pingPong",
                                                   "delay",
                                                   .01
                                                  )
                     );

		StartCoroutine(GameOver());

	}

	IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2);
        print("GAME OVER");
    }


}
