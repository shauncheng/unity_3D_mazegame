﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
	private int s = 0;
	// Use this for initialization
	void Start ()
	{
		
	}


	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			s++;
			Debug.Log ("pac:" + s);
			Destroy (this);
		}

	}
}
