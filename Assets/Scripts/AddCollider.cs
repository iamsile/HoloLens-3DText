﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.AddComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
