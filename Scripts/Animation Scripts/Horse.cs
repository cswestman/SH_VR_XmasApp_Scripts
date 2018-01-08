using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Horse : MonoBehaviour, IPointerClickHandler {

	public Animator animHorse; 
	public bool activateHorse = false;
	// Use this for initialization
	void Start () {
		animHorse = GetComponent<Animator>();
	}
	
	public void ActiveHorse()
	{
			activateHorse = !activateHorse;
			animHorse.SetBool("HorseActive", activateHorse);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveHorse();
			
	}
}
