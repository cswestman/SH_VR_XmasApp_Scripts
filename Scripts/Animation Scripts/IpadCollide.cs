using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IpadCollide : MonoBehaviour {

	
	public Collider iCollide;

	public float timeLeft = 14.0f;
 	bool timerActive = false;
	// Update is called once per frame

	void Start () 
	{
		iCollide = this.GetComponent<Collider>();

	}

	public void EngageIpad()
	{
		iCollide.enabled = false;
		StartTimer();
	}

	void Update()
	{
		if(timerActive == true)
		{
			timeLeft -= Time.deltaTime;
			if(timeLeft <= 0.0f){
				iCollide.enabled = true;
				timerActive = false;
				timeLeft = 14.0f;
			}
		}
		
	}

	void StartTimer()
	{
		timerActive = true;
	}

	

}
