using UnityEngine;
using System.Collections;

public class KobitControl : MonoBehaviour {

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

	void TupUp()
	{
		isTup = false;
	}

	void TupDown()
	{
		isTup = true;
	}
}
