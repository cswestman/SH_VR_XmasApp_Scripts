using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallPlane : MonoBehaviour, IPointerClickHandler {

	public Animator animBallPlane; 
	public bool activateBallPlane = false;
	// Use this for initialization
	void Start () {
		animBallPlane = GetComponent<Animator>();
	}
	
	public void ActiveBallPlane()
	{
			activateBallPlane = !activateBallPlane;
			animBallPlane.SetBool("BallPlaneActive", activateBallPlane);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveBallPlane();
			
	}
}
