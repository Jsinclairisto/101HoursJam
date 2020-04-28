using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool grabbed;
    Rigidbody2D rb2D;
    public float distance = 2f;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        RayCastHit2D hit = Physics2D.RayCast(transform.position, Vector2.right);
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(!grabbed)
            {
            

            }
            else
            {
                
            }
        }
    }

}
