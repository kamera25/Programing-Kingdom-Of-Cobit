using UnityEngine;
using System.Collections;

public class TapControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
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
				Debug.Log("hit object is " + hitObject.collider.gameObject.name);
			}
		}

	}
}
