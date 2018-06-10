using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountActiveFlies : MonoBehaviour {

	public Monster monster;
	public Text successText;
	
	// Update is called once per frame
	void Update () {
		if (!monster.closedMouth) {
			int numFlies = 0;
			foreach (Transform fly in transform) {
				if (fly.gameObject.activeSelf) {
					numFlies++;
				}
			}
			if (numFlies == 0) {
				successText.gameObject.SetActive (true);
			}
		}
	}
}
