using UnityEngine;
using System.Collections;

public class StopButtonControl : MonoBehaviour {

	GameObject playButton;
	public GameObject kobit;

	// Use this for initialization
	void Start () {
		playButton = GameObject.Find("Play");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TupDown()
	{
		playButton.transform.position = new Vector3( playButton.transform.position.x, playButton.transform.position.y, 0);
		this.transform.position = new Vector3( this.transform.position.x, this.transform.position.y, 1);// my invisible
		kobit.BroadcastMessage("StopApps");
	}
}
