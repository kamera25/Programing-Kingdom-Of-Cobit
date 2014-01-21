using UnityEngine;
using System.Collections;

public class ProgramBlockControl : MonoBehaviour {

	public GameObject Obj;
	bool isTup = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( isTup)
		{
			Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			pos.z = 0;
			this.transform.position = pos;
		}
	}

	void SetIsTupToFalse()
	{
		isTup = false;
	}

	void TupUp()
	{
		isTup = false;

	}
	
	void TupDown()
	{
		if( this.CompareTag("OnPlate"))
		{
			GameObject clone;
			clone = Instantiate( Obj) as GameObject; 
			clone.tag = "OnPlate";
			clone.SendMessage( "SetIsTupToTrue");
			this.tag = "NonPlate";
			this.gameObject.layer = LayerMask.NameToLayer("Default");
		}

		this.GetComponent<AudioSource>().Play();
		isTup = true;
	}
}
