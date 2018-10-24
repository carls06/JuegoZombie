using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Generador : MonoBehaviour {
    public GameObject[] obj;
    public float timeMin = 1.25f;
    public float timeMAx = 2.5f;
    private bool fin = false;
 

    
    // Use this for initialization
    void Start () {
        
        NotificationCenter.DefaultCenter().AddObserver(this, "personajecorre");
         NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

    }

    void personajecorre(Notification notification) {
        Generar();

    }
    void PersonajeHaMuerto()
    {
        fin = true;
        //SceneManager.LoadScene("gameOver");
    }

    // Update is called once per frame
    void Update () {
		
	}
    private Puntuacion puntuacion;
    void Generar()
    {
        if (!fin)
        {
        
                Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
                Invoke("Generar", Random.Range(timeMin, timeMAx));
         
            

        }
    }

}
