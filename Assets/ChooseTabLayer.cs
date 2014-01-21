using UnityEngine;
using System.Collections;

public class ChooseTabLayer : MonoBehaviour {

	public string name;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TupDown()
	{
		int layerNo = LayerMask.NameToLayer(name);
		for( int i = 8; i <=9 ; i++)
		{
			Camera.main.cullingMask &= ~(1<<i);
		}
		Camera.main.cullingMask |=  (1<<layerNo);
	}

	void TupUp()
	{

	}
}
