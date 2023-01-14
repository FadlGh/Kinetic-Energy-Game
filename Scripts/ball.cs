using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public bool add;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            add = !add;
        }

    }

    private void FixedUpdate()
    {
        if (add)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
           rb.angularDrag = 30 / rb.mass - 0.8f;
        }
    }
}
