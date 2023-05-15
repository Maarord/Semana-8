using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionControl : MonoBehaviour
{
    public const int MAX_JUMPS=2;
    private bool onGround = false;
    private int currentJumps=0;

    public bool CanJump(){
        Debug.Log(onGround);
        Debug.Log(currentJumps);
    return onGround || (!onGround && currentJumps < MAX_JUMPS);
    }

     public void Jump () {
    currentJumps++;
    onGround = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject);
        onGround = true;
        currentJumps=0;
        }

     void OnTriggerEnter2D(Collider2D collisioncontrol)
    {
        if (collisioncontrol.gameObject.tag == "Zom1")
        {
            //CanJump();
            Jump ();
        }
    }
}
