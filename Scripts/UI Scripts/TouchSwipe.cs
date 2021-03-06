﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSwipe : MonoBehaviour {

	private Touch initTouch = new Touch();
	public Camera cam;

	private float rotX = 0f;
	private float rotY = 0f;

	private Vector3 origRot;

	public float rotSpeed = 0.5f;
	public static float dir = 1; 

	// Use this for initialization
	void Start () 
	{
		origRot = cam.transform.eulerAngles;
		rotX = origRot.x;
		rotY = origRot.y;
	}
	
	// Update is called once per frame
	void Update () 
	{
		foreach(Touch touch in Input.touches)
		{
			if(touch.phase == TouchPhase.Began)
			{
				initTouch = touch;
			}
			else if(touch.phase == TouchPhase.Moved) 
			{
				float deltaX = initTouch.position.x - touch.position.x;
				float deltaY = initTouch.position.y - touch.position.y;
				rotX -= deltaY * Time.deltaTime * rotSpeed * dir;
				rotY += deltaX * Time.deltaTime * rotSpeed * dir;
				rotX = Mathf.Clamp(rotX, -80f, 80f);
				cam.transform.eulerAngles = new Vector3(rotX, rotY, 0f);
			}
			else if(touch.phase == TouchPhase.Ended) 
			{
				initTouch = new Touch();
			}
		}
	}
}
