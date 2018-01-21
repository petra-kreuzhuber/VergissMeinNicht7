using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPills : MonoBehaviour {

//	public ChangeList ChangeList;
	// Update is called once per frame
	void OnMouseDown(){
		Destroy (gameObject);
		//ChangeList.pills = true;

	}
	/*
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Destroy (GetComponent<MeshRenderer>());
		}
	}
	*/
}
