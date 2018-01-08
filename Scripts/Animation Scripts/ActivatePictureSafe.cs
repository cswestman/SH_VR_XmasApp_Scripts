using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivatePictureSafe : MonoBehaviour, IPointerClickHandler  {

	public Animator animPicture; 
	public bool openSafe = false;
	// Use this for initialization
	void Start () {
		animPicture = GetComponent<Animator>();
	}
	
	public void OpenSafe(){
			openSafe = !openSafe;
			animPicture.SetBool("OpenSafe", openSafe);
	}

	public void OnPointerClick(PointerEventData eventData){
			OpenSafe();
			
	}
}
