using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaControl : MonoBehaviour
{
    public float velocityX = 3f;
    public float velocityY =3f ;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5);
    }

    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
       /* if(Input.GetKeyDown(KeyCode.A))
        {
            BalasDispersas();
        }*/

    }

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("trigger");
        Debug.Log(other.gameObject.name);
        Destroy(this.gameObject);
    }

    /*public void BalasDispersas()
    {
    var bala1 = Instantiate(gameObject,position,Quaternion.identity);
    var BalaControl1= bala1.GetComponent<BalaControl>();
    BalaControl1.velocityX=velocityX -1f;
    BalaControl1.velocityY=velocityY +1;
    
    var bala2 = Instantiate(gameObject,transform.position,Quaternion.identity);
    var BalaControl2= bala2.GetComponent<BalaControl>();
    BalaControl2.velocityX=velocityX +1f;
    BalaControl2.velocityY=velocityY -1f;
    }*/

}