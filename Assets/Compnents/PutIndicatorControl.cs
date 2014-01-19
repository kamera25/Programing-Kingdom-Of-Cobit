using UnityEngine;
using System.Collections;

public class PutIndicatorControl : MonoBehaviour {

	GameObject indicator;	
	float putTime;

	// Use this for initialization
	void Start () {
		indicator = Instantiate(Resources.Load("fukidashi")) as GameObject;
		indicator.name = "fukidashi" + 1;
		putTime = 6;
	}
	
	// Update is called once per frame
	void Update () {
	
		if( 0 < putTime)
		{
			indicator.transform.position = new Vector3( this.transform.position.x+1, this.transform.position.y+2, -1);

		}
		else
		{
			indicator.transform.position = new Vector3( 100, 100, -1);
		}

		putTime -= Time.deltaTime;
	}

	void PutMessage( string mes)
	{
		indicator.transform.FindChild("text").GetComponent<TextMesh>().text = mes;
		putTime = 6;
	}

}
