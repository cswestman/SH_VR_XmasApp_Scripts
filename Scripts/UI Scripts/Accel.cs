using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour {

		public GameObject cam;
		

		 void Update(){
			 cam.transform.rotation = new Quaternion(Input.acceleration.x, -Input.acceleration.y, Input.acceleration.z, 0);
		 }

}
