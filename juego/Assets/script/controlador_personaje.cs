using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_personaje : MonoBehaviour {


    public float fuerza_salto = 100f;
    private Rigidbody2D rb2D;
    private Animator animator;
    private bool enSuelo = true;
    public Transform comprobadorSuelo;
    private float comprobarRadio = 0.1f;
    public LayerMask mascaraSuelo;
    private bool corriendo = false;
    public float velocidad = 1f;
    private AudioSource audioSource;

    private bool dobleSalto = false;
    // Use this for initialization
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start () {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) {
            if (corriendo)
            {
                if (enSuelo || !dobleSalto)
                {
                    audioSource.Play();
                    rb2D.AddForce(new Vector2(0, fuerza_salto));

                }
                if (!dobleSalto && !enSuelo)
                {
                    dobleSalto = true;
                }
            }else
            {
                corriendo = true;
                NotificationCenter.DefaultCenter().PostNotification(this, "personajecorre");
            }
        }

      
    }

    private void FixedUpdate()
    {

        if (corriendo) {
            rb2D.velocity = new Vector2(velocidad, rb2D.velocity.y);
        }
        animator.SetFloat("velx", rb2D.velocity.x);
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobarRadio, mascaraSuelo);
        animator.SetBool("inGround", enSuelo);

        if (enSuelo)
        {
            dobleSalto = false;
        }

        
    }
}

