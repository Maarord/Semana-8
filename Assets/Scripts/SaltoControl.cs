using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltoControl : MonoBehaviour
{
    public ColisionControl colisioncontrol;
    public float jumpForce = 25f;
    private Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) &&  colisioncontrol.CanJump()){
        rb.AddForce(transform.up* jumpForce);
        colisioncontrol.Jump();
        }
    }

  
}

