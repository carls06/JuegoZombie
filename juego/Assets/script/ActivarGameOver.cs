using UnityEngine;
using System.Collections;

public class ActivarGameOver : MonoBehaviour {
    private AudioSource audioo;
	public GameObject camaraGameOver;
	public AudioClip gameOverClip;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");
        audioo = GetComponent<AudioSource>();


    }
	
	void PersonajeHaMuerto(Notification notificacion){
        audioo.Stop();
        GetComponent<AudioSource>().clip = gameOverClip;
        GetComponent<AudioSource>().loop = false;
        GetComponent<AudioSource>().Play();
        camaraGameOver.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
