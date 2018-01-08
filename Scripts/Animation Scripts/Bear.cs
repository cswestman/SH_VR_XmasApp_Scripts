using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bear : MonoBehaviour, IPointerClickHandler {

	public Animator animBear;
	public bool activateBear = false;

	// Use this for initialization
	void Start () {
		animBear = GetComponent<Animator>();
	}
	
	public void ActiveBear()
	{
			activateBear = !activateBear;
			animBear.SetBool("BearActive", activateBear);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveBear();
			
	}
}
