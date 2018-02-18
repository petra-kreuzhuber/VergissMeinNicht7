  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeList : MonoBehaviour {

    public bool cat = false;
	public bool pencil = false;
	public bool pills = false;
    public bool phone = false;


	public GameObject otherGameObject;
	private PickPills pickPills;
    public AudioSource[] sounds;
    public AudioSource audio1;
    public AudioSource audio2;


    bool PlaySound;

    //private Material a;
	void Awake() {
	//	pickPills = GetComponent<PickPills> ();
	}
    // Use this for initialization
    void Start () {
        // GetComponent<Image>().sprite = Resources.Load("C: \\Users\\Petra\\Documents\\GitHub\\games\\VergissMeinNichtUpdate\\Prototype1\\Assets\\Liste2.png", typeof(Sprite)) as Sprite;
        // GetComponent<MeshRenderer>().material = GetComponent<MeshRenderer>().materials[0];
        //GetComponent<MeshRenderer>().material = a;

        sounds = GetComponents<AudioSource>();
        audio1 = sounds[1];
        audio2 = sounds[2];
    }
	
	// Update is called once per frame
	void Update () {
		if (cat && pills && phone && pencil) {
			GetComponent<MeshRenderer> ().material = Resources.Load ("Liste4") as Material;
		} else if (cat && pills && pencil) {
			//   StartCoroutine(Wait());
            
			GetComponent<MeshRenderer> ().material = Resources.Load ("Liste3") as Material;
		} else if (cat && pencil) {
           
			audio2.Play ();
			GetComponent<MeshRenderer> ().material = Resources.Load ("Liste2") as Material;
		} else {
			audio1.Play();
		}

    }

    /*
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5.0f);
        PlaySound = true;
    }
    */

    bool getCat()
    {
        return cat;
    }
    void setCat(bool NEW) {
        cat = NEW;
    }
   
    bool getPhone()
    {
        return phone;
    }
    void setPhone(bool NEW)
    {
        phone = NEW;
    }
     bool getPencil()
    {
        return pencil;
    }
    void setPencil(bool NEW) {
        pencil = NEW;
        }
}
