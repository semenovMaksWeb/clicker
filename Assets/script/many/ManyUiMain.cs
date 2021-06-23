using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManyUiMain : MonoBehaviour {
	void Start () {
 
	}
	public void setManyUiMain(int value){
		GetComponent<Text>().text = value.ToString();
	}
}
