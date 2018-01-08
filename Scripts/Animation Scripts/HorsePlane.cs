using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HorsePlane : MonoBehaviour, IPointerClickHandler {

	public Animator animHorsePlane; 
	public bool activateHorsePlane = false;
	// Use this for initialization
	void Start () {
		animHorsePlane = GetComponent<Animator>();
	}
	
	public void ActiveHorsePlane()
	{
			activateHorsePlane = !activateHorsePlane;
			animHorsePlane.SetBool("HorsePlaneActive", activateHorsePlane);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveHorsePlane();
			
	}
}
