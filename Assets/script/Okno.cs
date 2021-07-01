using UnityEngine.EventSystems;
using UnityEngine;

public class Okno : MonoBehaviour, IPointerClickHandler {
	public Flags flags;
	public MonoBehaviour menuExit;
	public void OnPointerClick(PointerEventData pointerEventData)
	{
		flags.flagAddMoneta = false;
		menuExit.gameObject.SetActive (true);
		//Application.Quit();
	}
}
