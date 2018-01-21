using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPencil : MonoBehaviour {
	//public ChangeList ChangeList;

	void OnMouseDown(){
		Destroy (gameObject);
		//ChangeList.pencil = true;

	}
	// Update is called once per frame
	//void Update () {
		//if (Input.GetKeyDown (KeyCode.Mouse0)) {
		//	Destroy (GetComponent<MeshRenderer>());
		//}
//}
}
