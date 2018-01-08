using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TeleportTo : MonoBehaviour, IPointerClickHandler {


	public void OnPointerClick(PointerEventData eventData){
		GameObject player = GameObject.Find("Player");
		player.transform.position = 
			new Vector3(this.transform.position.x,
									player.transform.position.y,
									this.transform.position.z);
	}

	

}
