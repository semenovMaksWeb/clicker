using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class main : MonoBehaviour {
	private Save save;
	private Load load;
	public ManyUiMain manyUiMain;
	public MonetkaMain monetkaMain;
	int countMany = 0;

	void Start () {
		save = new Save ();
		load = new Load ();
		countMany = load.getCountMany ();
		Debug.Log (countMany);
		manyUiMain.setManyUiMain (countMany);
	}
	void AddMany(){
		countMany++;
		GameObject.Instantiate (monetkaMain);
		manyUiMain.setManyUiMain (countMany);
		save.SetCountMany (countMany);
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) ){
			AddMany();
		}
	}
}
