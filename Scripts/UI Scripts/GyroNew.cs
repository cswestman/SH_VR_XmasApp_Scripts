using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroNew : MonoBehaviour {

	private bool gyroEnabled;
	private Gyroscope gyro;

	public GameObject cameraContainer;
	private Quaternion rot;

	private void Start()
	{
		gyro = Input.gyro;
		gyro.enabled = true;

		//cameraContainer.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
		rot = new Quaternion(0, 0, 1, 0);
	}
	

	

	private void Update()
	{
		transform.localRotation = gyro.attitude * rot;
	}
		
	
}
