using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shuttle : MonoBehaviour, IPointerClickHandler  {

	public Animator animShuttle;
	public bool shuttleTakeOff = false;


	// Use this for initialization
	void Start () {
		animShuttle = GetComponent<Animator>();
	}
	
	public void OnPointerClick(PointerEventData eventData){
			shuttleTakeOff = !shuttleTakeOff;
			animShuttle.SetBool("ShuttleTakeOff", shuttleTakeOff);

			// timerRunning = true;
			
	}
}
