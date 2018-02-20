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
		yield return new WaitForSeconds (300);
		display = true;
		//Destroy (gameObject);
	}


	void OnGUI()
	{
		if (display == true) {
			GUI.Box (new Rect (0, 100, Screen.width, 150), "In Österreich gibt es ca. 130000 Menschen, die an einer dementiellen Erkrankung leiden \n Aufgrund des kontinuierlichen Altersanstiegs in der Bevölkerung wird sich diese Anzahl bis zum Jahr 2050 verdoppeln \n und der Betreuungs- und Pflegebedarf wird somit weiter steigen. \n Weit mehr als die hHölfte aller Demenzpatienten haben die Alzheimerkrankheit. \n AlzheimerpatientInnen leiden an langsam fortschreitenden Gedächtnis- und Denkstörungen und infolge dessen an \n Beeinträchtigungen der Alltagsaktivität. Ebenfalls gehören das Vergessen von kurz zurückliegenden Ereignissen, Problemen mit der zeitlichen und örtlichen \n Orientierung sowie Schwierigkeiten beim Fällen von Entscheidungen \n zu den Warnzeichen für beginnende Demenz. ");
		}
	}
}
