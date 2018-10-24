using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {


    

    public int puntosGanados = 5;
    public AudioClip itemSoundClip;
    public float itemSoundVolume = 1f;

    // Use this for initialization
    void Start () {
        //audioItem = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
            AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);

        }
        Destroy(gameObject);
    }
}
