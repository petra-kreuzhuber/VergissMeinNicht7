 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class ChangeList : MonoBehaviour {

    endScreen temp = new endScreen();
    public bool cat = false;
	public bool pencil = false;
	public bool pills = false;
    public bool phone = false;
     

	public GameObject otherGameObject;
	private PickPills pickPills;
    public AudioSource[] sounds;
    public AudioSource audio1;
    public AudioSource audio2;
    public double timer;

	//Variablen für Audio in der Update
    bool biggerThanTimer = false;
	bool biggerThanTimer2 = false;
	bool biggerThanTimer3 = false;
	bool biggerThanTimer4 = false;
	bool biggerThanTimer5 = false;
	bool biggerThanTimer6 = false;


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
        timer = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        
 
        //erster Katzenruf gleich am Anfang
        if (Time.time > timer + 20 && !biggerThanTimer)
        {
            biggerThanTimer = true;
            audio1.Play();
        }
		//Timer wird nach Stiftaufnahme neu gesetzt
		if (pencil && !biggerThanTimer2) {
			biggerThanTimer2 = true;
			biggerThanTimer3 = true;
			timer = Time.time;
		}

		// 2. Katzenruf nach Aufnahme von Stift und bestimmter Zeit und Katzenaufgabe gilt als abgeschlossen
		if (Time.time > timer + 20 && biggerThanTimer3) {
			biggerThanTimer3 = false;
			audio1.Play ();
			cat = true;
		}

		// Timer wird nach Pillenaufnahme neu gesetzt
		if (pills && !biggerThanTimer4) {
			biggerThanTimer4 = true;
			biggerThanTimer5 = true;
			timer = Time.time;
		}

		//Nach Pillenaufnahme und bestimmter Zeit wird Telefongeräusch abgespielt
		if (Time.time > timer + 20 && biggerThanTimer5) {
			biggerThanTimer5 = false;
			biggerThanTimer6 = true;
			audio2.Play ();
			timer = Time.time;
		}

		//nach bestimmter Zeit wird Telephon abgeschlossen 
		if (Time.time > timer + 25 && biggerThanTimer6) {
			phone = true;
            temp.showScreen("EndScreen");


        }

		//updatet die Liste je nach Variablenzustand
		listUpdate ();
    }

    


    //Getter und Setter
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


	//updatet Liste je nach Variablenzustand
	void listUpdate() {
		//Wenn alle Aufgaben erfüllt sind wird die vollstänig abgehakte Liste angezeigt
		if (cat && pills && phone && pencil) {
			GetComponent<MeshRenderer> ().material = Resources.Load ("Liste4") as Material;
		}
		//Wenn Pillen und Katze schon erfüllt werden diese beiden abgehackt
		else if (cat && pills && pencil) { 
			GetComponent<MeshRenderer> ().material = Resources.Load ("Liste3") as Material;
		}
		//wenn Katze schon erfüllt wird dieses abgehackt
		else if (cat && pencil) {
			GetComponent<MeshRenderer> ().material = Resources.Load ("Liste2") as Material;
		}
	}
}
