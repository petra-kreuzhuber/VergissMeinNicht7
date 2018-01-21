using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPills : MonoBehaviour {

	public GameObject otherGameObject;
	private ChangeList changeList;

	void Awake(){
		changeList = otherGameObject.GetComponent<ChangeList> ();
	}

	// Update is called once per frame
	void OnMouseDown(){
		
		Destroy (gameObject);



	}
		
	void OnDestroy() {
		changeList.pills = true;
	}
}
