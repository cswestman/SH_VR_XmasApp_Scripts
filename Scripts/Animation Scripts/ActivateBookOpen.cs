using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivateBookOpen : MonoBehaviour, IPointerClickHandler  {

	public Animator animBookOpen; 
	private bool activateBookOpen = false;
	// Use this for initialization
	void Start () {
		animBookOpen = GetComponent<Animator>();
	}
	

	public void OnPointerClick(PointerEventData eventData){
			activateBookOpen = !activateBookOpen;
			animBookOpen.SetBool("ActivateBookOpen", activateBookOpen);
			
	}
}