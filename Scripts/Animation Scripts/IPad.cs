using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IPad : MonoBehaviour, IPointerClickHandler {
	// Animator for iPad
	public Animator animIpad; 
	public bool activateIpad = false;
	private Collider iPadColl;


	// Use this for initialization
	void Start () {
		animIpad = GetComponent<Animator>();
	}
	
	public void ActiveIpad()
	{
			activateIpad = !activateIpad;
			animIpad.SetBool("GetiPad", activateIpad);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveIpad();
			
	}
}
