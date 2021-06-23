using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Save {
	public void SetCountMany(int value){
		PlayerPrefs.SetInt("CountMany", value);
		PlayerPrefs.Save();
	}
}
