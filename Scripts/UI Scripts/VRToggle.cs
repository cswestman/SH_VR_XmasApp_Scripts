using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.EventSystems;

public class VRToggle : MonoBehaviour, IPointerClickHandler
{
	public Camera cam;

	private float rotX = 0f;
	private float rotY = 0f;

	private Vector3 origPos;

	public void OnPointerClick(PointerEventData eventData){
		ToggleVR();
		
	}

	void Start () 
	{
		origPos = cam.transform.eulerAngles;
		rotX = origPos.x;
		rotY = origPos.y;
	}
		

	void ToggleVR()
	{

			if(UnityEngine.XR.XRSettings.loadedDeviceName == "carboard")
			{
				
				StartCoroutine(LoadDevice("None"));
				origPos.x = rotX;
				origPos.y = rotY;
				cam.transform.eulerAngles = origPos;
				ResetCameras();
			}
			else 
			{
				StartCoroutine(LoadDevice("cardboard"));
				origPos.x = rotX;
				origPos.y = rotY;
				cam.transform.eulerAngles = origPos;
			}

    }

    IEnumerator LoadDevice(string newDevice)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }

		void ResetCameras() {
      // Camera looping logic copied from GvrEditorEmulator.cs
      for (int i = 0; i < Camera.allCameras.Length; i++) {
        Camera cam = Camera.allCameras[i];
        if (cam.enabled && cam.stereoTargetEye != StereoTargetEyeMask.None) {
          // Reset local rotation. (Only required if you change the local rotation while in non-VR mode.)
          cam.transform.localRotation = Quaternion.identity;
          // Reset local position. (Only required if you change the local position while in non-VR mode.)
          cam.transform.localPosition = Vector3.zero;
          // Reset aspect ratio based on normal (non-VR) screen size.
          cam.ResetAspect();
          // Don't need to reset camera `fieldOfView`, since it's restored to the original value automatically.
        }
      }
    }
}