using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Main : MonoBehaviour {
	private Save save;
	private Load load;
	public Many many;
	public Flags flags;
	public ManyUiMain manyUiMain;
	public MonetkaMain monetkaMain;
	void Start () {
		save = new Save ();
		load = new Load ();
		many = new Many (load.getCountMany ()); // значение монет взятое с файла
		manyUiMain.setManyUiMain (many.countMany);
	}
	void clickBody(){
		many.AddMany (); // ++ 1 монетка
		GameObject.Instantiate (monetkaMain); // добавить монетку на поле
		manyUiMain.setManyUiMain (many.countMany); // записать новое значение в text
		save.SetCountMany (many.countMany); // сохранить  в файле новое значение монет
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && flags.flagAddMoneta){
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			clickBody();
		}
	}
}
