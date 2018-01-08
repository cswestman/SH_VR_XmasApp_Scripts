using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drone : MonoBehaviour, IPointerClickHandler {


	public Animator animDrone;
	public bool takeOff = false;

	// public float waitTime = 18f;
	// float timer;
	// bool timerRunning;

	// Use this for initialization
	void Start () {
		animDrone = GetComponent<Animator>();
	}

	// void Update(){
	// 	if(timerRunning){
	// 		StartTimer();
	// 	}
	// }
	
	// void StartTimer(){
	// 	//Timer for triggering and resetting takeOff
	// 		timer += Time.deltaTime;
	// 		if (timer > waitTime) {
	// 			takeOff = !takeOff;
	// 			animDrone.SetBool("TakeOff", takeOff);
	// 			timer = 0f;
	// 			timerRunning = false;
				
	// 			}
	// }

	public void OnPointerClick(PointerEventData eventData){
			takeOff = !takeOff;
			animDrone.SetBool("TakeOff", takeOff);

			// timerRunning = true;
			
	}

}
