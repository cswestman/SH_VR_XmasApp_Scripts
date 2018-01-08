using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour, IPointerClickHandler{

	public Animator animBall; 
	public bool activateBall = false;
	// Use this for initialization
	void Start () {
		animBall = GetComponent<Animator>();
	}
	
	public void ActiveBall()
	{
			activateBall = !activateBall;
			animBall.SetBool("BallActive", activateBall);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveBall();
			
	}
}
