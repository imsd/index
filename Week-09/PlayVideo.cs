﻿using UnityEngine;
using System.Collections;
using UnityEngine.Video;	// important!

public class PlayVideo : MonoBehaviour {

	// add a .mov into your project and add it to the object,
	// then attach this script and modify
	
	public VideoPlayer vidp;

	void Start() {
		vidp.Play ();	// just call this whenever you need
	}
}