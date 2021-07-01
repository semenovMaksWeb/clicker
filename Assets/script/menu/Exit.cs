using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Exit : MonoBehaviour {
	public void gamesOver(){
		Application.Quit();
	}
}
