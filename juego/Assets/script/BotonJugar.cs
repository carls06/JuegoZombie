using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour {


    AudioSource audioData;
    public GameObject camara;
    public TextMesh text;
    

   
    // Use this for initialization
    void Start () {
        audioData = GetComponent<AudioSource>();
      
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){

        
        if (text.tag == "Play")
        {
            camara.GetComponent<AudioSource>().Stop();
            audioData.Play();
            SceneManager.LoadScene("GameScenes");
        }
        else
        {
        
            camara.GetComponent<AudioSource>().Stop();
            audioData.Play();
            SceneManager.LoadScene("infoScenes");
        }

    }



}
