using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SnowGlobe : MonoBehaviour, IPointerClickHandler {

	public Animator animSnowGlobe;
	public bool activateSnowGlobe = false;

	// Use this for initialization
	void Start () {
		animSnowGlobe = GetComponent<Animator>();
	}
	
	public void ActiveSnowGlobe()
	{
			activateSnowGlobe = !activateSnowGlobe;
			animSnowGlobe.SetBool("GlobeActive", activateSnowGlobe);
	}

	public void OnPointerClick(PointerEventData eventData){
			ActiveSnowGlobe();
			
	}
}
