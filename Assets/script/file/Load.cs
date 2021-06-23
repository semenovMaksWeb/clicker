using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load {
	public int getCountMany(){
		if(PlayerPrefs.HasKey("CountMany")){
			return PlayerPrefs.GetInt ("CountMany");
		}
		return 0;
	}
}
