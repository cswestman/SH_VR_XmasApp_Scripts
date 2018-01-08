using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivateSlide : MonoBehaviour, IPointerClickHandler  {

	public Animator animSlide; 
	public bool openSlide = false;
	// Use this for initialization
	void Start () {
		animSlide = GetComponent<Animator>();
	}
	
	public void OpenSlide(){
			openSlide = !openSlide;
			animSlide.SetBool("OpenSlide", openSlide);
	}

	public void OnPointerClick(PointerEventData eventData){
			OpenSlide();
			
	}
}