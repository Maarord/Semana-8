using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieControl : MonoBehaviour
{
    SpriteRenderer sr;
    int vCorrer= 5;
    public float xVelocity =7f;
    private Rigidbody2D rb;
    public GameObject bala;
    int jumpForce= 15;
    public GameManagerControl game_control;
    public GameObject bullet;
    private AudioSource audioSource;

    public AudioClip saltarClip;
    public AudioClip monedaClip;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        game_control= FindObjectOfType<GameManagerControl>();
        audioSource= GetComponent <AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            sr.flipX = false;
            rb.velocity = new Vector2(vCorrer, rb.velocity.y);
             
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            sr.flipX = true;
            rb.velocity = new Vector2(-vCorrer, rb.velocity.y);
            }
        else if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up*jumpForce);
            //audioSource.PlayOneShot(saltarClip);
        }
        else if (Input.GetKeyUp(KeyCode.O))
        { 
            var currentPosition = transform.position;
            var position = new Vector3(currentPosition.x +1, currentPosition.y, 10);
            var balaGO = Instantiate(bala, position, Quaternion.identity);
            var controller = balaGO.GetComponent<BalaControl>();
            controller.velocityX = 5f;
        }
       
        else if (Input.GetKeyUp(KeyCode.K))
        {
           
            var currentPosition = transform.position;
            var position = new Vector3(currentPosition.x -1, currentPosition.y, 10);
            var balaGO = Instantiate(bala, position, Quaternion.identity);
            var controller = balaGO.GetComponent<BalaControl>();
            controller.velocityX = -5f;
        }
 }
        public void Saltar (){
        rb.AddForce(transform.up*jumpForce);
          
  }
   public void Disparar (){
     var currentPosition = transform.position;
            var position = new Vector3(currentPosition.x +1, currentPosition.y, 10);
            var balaGO = Instantiate(bala, position, Quaternion.identity);
            var controller = balaGO.GetComponent<BalaControl>();
            controller.velocityX = 5f;
   }

        void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Zom1")
        {
            Destroy (other.gameObject);
            game_control.lifePersonaje();
            
           

            if(game_control.Life == 0){
               Time.timeScale = 0;  
            }
        }
       
    }
      void OnTriggerEnter2D  (Collider2D other)
      {
         if (other.gameObject.tag == "MON")
        {
            Destroy (other.gameObject);
            game_control.monePersonaje();
           
            audioSource.PlayOneShot(monedaClip);
        }
      }
    }
    