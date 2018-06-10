using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighbourPopup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
    	iTween.MoveBy(this.gameObject, iTween.Hash("y", 
    	                                           6, 
    	                                           "easeType", 
    	                                           "easeInOutExpo", 
    	                                           "loopType", 
    	                                           "pingPong", 
    	                                           "delay", 
    	                                           .01
    	                                          )
    	             );

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PopUp()
	{
		//transform.Translate(0, 0, 0);
	}

	void OnMouseDown()
    {
        Debug.Log("Neighbour Clicked " + this.name);

       // this.gameObject.SetActive(false);
       // Destroy(this);
    }

}
