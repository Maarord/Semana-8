using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class EnemyControl : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public float velocity = 3f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-velocity, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bala")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }


    }
}*/
public class EnemyControl : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public float velocity = 3f;
    private Rigidbody2D rb;
    private int bulletCount = 2; // contador de balas
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-velocity, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bala")
        {
            Destroy(other.gameObject);
            bulletCount--; 
            if (bulletCount <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
