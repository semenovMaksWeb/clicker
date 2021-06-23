using UnityEngine.EventSystems;
using UnityEngine;

public class Exit : MonoBehaviour, IPointerClickHandler {
	public void OnPointerClick(PointerEventData pointerEventData)
	{
		Debug.Log ("Exit");
		//Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
		Application.Quit();
	}
}
