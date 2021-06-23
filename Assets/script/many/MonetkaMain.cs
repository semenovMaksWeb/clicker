using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonetkaMain : MonoBehaviour {
	
	float speed = 2f;
	// Use this for initialization
	void Start () {
		gameObject.layer = 5;
		//Renderer().sortingOrder ();
		transform.localPosition = new  Vector3 (1f, 0.3f, 0.0f);
	}
	void Update(){
		Translate ();
	}
	void Translate(){
		if (transform.localPosition.y >  -2.1f) {
			Invoke ("Translate", 2f);
			transform.Translate (0, -2.1f * Time.deltaTime * speed, 0f); 
		} else {
			Destroy (gameObject);
		}
	}
}