using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayEndText : MonoBehaviour {
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
			StartCoroutine ("WaitForSec");
		}
	}
	/*
	void OnTriggerExit(Collider coll2)
	{
		if (coll2.transform.name == "FPSController") {
			display = false;
			Destroy (gameObject);
		}
	}
	*/
	IEnumerator WaitForSec(){
		yield return new WaitForSeconds (360);
		display = true;
		//Destroy (gameObject);
	}


	void OnGUI()
	{
		if (display == true) {
			GUI.Box (new Rect (0, 50, Screen.width, 24), text);
		}
	}
}
