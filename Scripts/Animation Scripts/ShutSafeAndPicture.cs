using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShutSafeAndPicture : MonoBehaviour {

	Animator animSafeDoor;
	Animator animSafePicture;

	public GameObject safeObject;
	public GameObject pictureObject;

	bool safeOpen;
	bool pictureOpen;

	public float waitTime = 3f;
	float timer;
	bool timerRunning;

	// Use this for initialization
	void Start () 
	{
		animSafeDoor = safeObject.GetComponent<Animator>();
		animSafePicture = pictureObject.GetComponent<Animator>();
		safeOpen = animSafeDoor.GetBool("OpeningSafe");
		pictureOpen = animSafePicture.GetBool("OpenSafe");
	}

	public void ShutSafeDoor()
	{
		safeOpen = !safeOpen;
		animSafeDoor.SetBool("OpeningSafe", safeOpen);
	}

	public void ShutPicture()
	{
		pictureOpen = !pictureOpen;
		animSafePicture.SetBool("OpenSafe", pictureOpen);
	}

	void Update(){
		if(timerRunning){
			StartTimer();
		}
	}
	
	void StartTimer(){
			ShutSafeDoor();
			while(timer < waitTime)
			{
				timer += Time.deltaTime;
			}
			
			if (timer >= waitTime)
			{
				ShutPicture();
				timer = 0f;
				timerRunning = false;
			}
	}

	public void LockDown()
	{
		timerRunning = true;
	}
	

}
