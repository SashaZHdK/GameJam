﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateIt : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Go (){
		GetComponent<Animator> ().SetTrigger ("Go");
	}
}
