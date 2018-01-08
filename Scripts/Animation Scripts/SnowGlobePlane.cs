using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SnowGlobePlane : MonoBehaviour, IPointerClickHandler {

	public Animator animSnowGlobePlane;
	public bool activateSnowGlobePlane = false;

	// Use this for initialization
	void Start () {
		animSnowGlobePlane = GetComponent<Animator>();
	}
	
	public void ActiveSnowGlobePlane()
	{
			activateSnowGlobePlane = !activateSnowGlobePlane;
			animSnowGlobePlane.SetBool("GlobePlaneActive", activateSnowGlobePlane);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveSnowGlobePlane();
			
	}
}
