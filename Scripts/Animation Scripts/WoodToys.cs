using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WoodToys : MonoBehaviour, IPointerClickHandler {

	public Animator animFireTruck; 
	public bool activateFireTruck = false;
	// Use this for initialization
	void Start () {
		animFireTruck = GetComponent<Animator>();
	}
	
	public void ActiveFireTruck()
	{
			activateFireTruck = !activateFireTruck;
			animFireTruck.SetBool("ToysActive", activateFireTruck);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveFireTruck();
			
	}
}
