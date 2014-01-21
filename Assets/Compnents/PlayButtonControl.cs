using UnityEngine;
using System.Collections;

public class PlayButtonControl : MonoBehaviour {
	
		GameObject stopButton;
		public GameObject kobit;
		
		// Use this for initialization
		void Start () {
			stopButton = GameObject.Find("Stop");
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		void TupDown()
		{
			stopButton.transform.position = new Vector3( stopButton.transform.position.x, stopButton.transform.position.y, 0);
			this.transform.position = new Vector3( this.transform.position.x, this.transform.position.y, 1); //invisible
			kobit.BroadcastMessage("RunApps");
		}


}
