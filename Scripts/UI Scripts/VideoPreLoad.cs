using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoPreLoad : MonoBehaviour {

  public VideoPlayer videoPlayer;
	

	// Use this for initialization
	void Start () {
	
		videoPlayer.Prepare();
	}
	
	
	
}
