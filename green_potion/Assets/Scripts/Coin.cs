﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("currency collected");
		Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
