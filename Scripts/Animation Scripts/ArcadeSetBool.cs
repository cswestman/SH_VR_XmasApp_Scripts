using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArcadeSetBool : MonoBehaviour, IPointerClickHandler  {

	
	// public EventTrigger arcadeEvent;
	public GameObject onScreen;
	public GameObject offScreen;
	// private bool onScreenActive;
	// private bool offScreenActive;

	// Use this for initialization
	// void Start () {
	// 	// arcadeEvent = GetComponent<EventTrigger>();
	// 	onScreen = GameObject.Find("OnScreen");
	// 	offScreen = GameObject.Find("OffScreen");
	// 	// onScreenActive = onScreen.activeSelf;
	// 	// offScreenActive = offScreen.activeSelf;
	// }
	
	public void OnPointerClick(PointerEventData eventData){
			
			if(onScreen.activeSelf == false && offScreen.activeSelf == true)
			{
				onScreen.SetActive(true);
				offScreen.SetActive(false);
			} 
			else 
			{
				onScreen.SetActive(false);
				offScreen.SetActive(true);
			}
			
	}




}
