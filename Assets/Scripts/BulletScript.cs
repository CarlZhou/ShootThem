﻿using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (renderer.IsVisibleFrom(Camera.main) == false)
		{
			Destroy(gameObject);
		}
	}
}
