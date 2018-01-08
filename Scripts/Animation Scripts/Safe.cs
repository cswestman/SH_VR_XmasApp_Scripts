using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Safe : MonoBehaviour, IPointerClickHandler {



	public Animator animSafe; 
	public bool activateSafe = false;


	// Use this for initialization
	void Start () {
		animSafe = GetComponent<Animator>();
	
	}

	
	public void ActiveSafe()
	{
			activateSafe = !activateSafe;
			animSafe.SetBool("OpeningSafe", activateSafe);
	}


	public void OnPointerClick(PointerEventData eventData){
			ActiveSafe();
			
	}




}
