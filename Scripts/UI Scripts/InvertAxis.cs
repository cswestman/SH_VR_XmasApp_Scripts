using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.EventSystems;

public class InvertAxis : MonoBehaviour, IPointerClickHandler
{

	public GameObject axis;

	public float invertAxis; 

	void Start()
	{
		invertAxis = TouchSwipe.dir;
	}
	
	public void OnPointerClick(PointerEventData eventData){
		
		if(TouchSwipe.dir == -1)
		{
			TouchSwipe.dir = 1;
		}
		else
		{
			TouchSwipe.dir = -1;
		}

	}
}
