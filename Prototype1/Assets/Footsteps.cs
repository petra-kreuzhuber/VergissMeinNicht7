using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

    public CharacterController _CharController;
    private Rigidbody _RigBod;


    float GroundDistance;
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, GroundDistance + 0.1f);
    }

    // Use this for initialization
    void Start () {

        _RigBod = _CharController.GetComponent<Rigidbody>();

	}

	
	// Update is called once per frame
	void Update () {
        if (_CharController.isGrounded == true && _CharController.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
