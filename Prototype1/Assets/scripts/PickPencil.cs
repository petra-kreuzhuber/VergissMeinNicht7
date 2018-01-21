using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPencil : MonoBehaviour {

	public GameObject otherGameObject;
	private ChangeList changeList;


	void Awake(){
		changeList = otherGameObject.GetComponent<ChangeList> ();
	}

	void OnMouseDown(){
		Destroy (gameObject);

	}
	// Update is called once per frame
	/*
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Destroy (GetComponent<MeshRenderer>());
		}
	}
	*/
	void OnDestroy() {
		changeList.pencil = true;
	}
}
