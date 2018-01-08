using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BookClose : MonoBehaviour, IPointerClickHandler {
	// Declare var for book animator
	public Animator animBookClose; 
	private bool activateBookClose = false;
	// Declare var for picture object
	public GameObject safeDoor;
	public GameObject secretPic;
	// Declare var for book collider
	public Collider bookCollider;
	// Use this for initialization
	void Start () {
		animBookClose = GetComponent<Animator>();
		bookCollider = this.GetComponent<Collider>();
	
	}
	
	void Update()
	{
		if(secretPic.GetComponent<Animator>().GetBool("OpenSafe") == false)
		{
				bookCollider.enabled = false;
		}
		else if(safeDoor.GetComponent<Animator>().GetBool("OpeningSafe") == true)
			{
				bookCollider.enabled = false;
			}
			else
			{
				bookCollider.enabled = true;
			}
	}

	public void OnPointerClick(PointerEventData eventData){
			activateBookClose = !activateBookClose;
			animBookClose.SetBool("ActivateBookClose", activateBookClose);
	}
}
