using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayPenText : MonoBehaviour {


	public string text;
	bool display = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider coll)
	{
		if (coll.transform.name == "FPSController"){
			display = true;
		}
	}

	void OnTriggerExit(Collider coll2)
	{
		if (coll2.transform.name == "FPSController") {
		StartCoroutine ("WaitForSec");

		}
	}

	IEnumerator WaitForSec(){
		yield return new WaitForSeconds (2);
		display = false;
		Destroy (gameObject);
	}


	void OnGUI()
	{
		if (display == true) {
			GUI.Box (new Rect (0, 50, Screen.width, 24), text);
		}
	}
}
