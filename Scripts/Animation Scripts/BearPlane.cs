using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BearPlane : MonoBehaviour, IPointerClickHandler {

	public Animator animBearPlane;
	public bool activateBearPlane = false;

	// Use this for initialization
	void Start () {
		animBearPlane = GetComponent<Animator>();
	}
	
	public void ActiveBearPlane()
	{
			activateBearPlane = !activateBearPlane;
			animBearPlane.SetBool("BearPlaneActive", activateBearPlane);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveBearPlane();
			
	}
}
