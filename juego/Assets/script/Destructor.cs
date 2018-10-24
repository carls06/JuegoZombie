using UnityEngine;
using System.Collections;
using System;

public class Destructor : MonoBehaviour {


    GameObject personaje;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
            //Debug.Break();
            NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
            personaje = GameObject.Find("player1");
            personaje.SetActive(false);

        }
        else{
			Destroy(other.gameObject);
		}
	}
}
