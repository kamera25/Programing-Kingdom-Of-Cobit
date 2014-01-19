﻿using UnityEngine;
using System.Collections;

public class TapControl : MonoBehaviour {

	public GameObject kobit;

	// Use this for initialization
	void Start () {
		kobit = GameObject.Find("kobito");
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown(0)) {
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
			RaycastHit2D hitObject = Physics2D.Raycast(tapPoint,-Vector2.up);
			if (hitObject) {
				hitObject.collider.gameObject.SendMessage("TupDown");
				hitObject.collider.gameObject.GetComponent<AudioSource>().Play();
				kobit.gameObject.SendMessage("PutMessage", "hello");
				Debug.Log("hit object is " + hitObject.collider.gameObject.name);
			}
		}

	}
}
