using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMenuExit : MonoBehaviour {
	public MonoBehaviour menuExit;
	public Flags flags;
	public void hidderMenu(){
		flags.flagAddMoneta = true;
		menuExit.gameObject.SetActive (false);
	}
	 
}
