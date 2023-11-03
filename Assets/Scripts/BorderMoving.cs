using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x == 500 && transform.position.y <= 350)
        {
            transform.Translate(Vector2.up * moveSpeed);
        }

        if (transform.position.x <= 500 && transform.position.y == 350)
        {
            transform.Translate(Vector2.left * moveSpeed);
        }

        if (transform.position.x == 235 && transform.position.y <= 350)
        {
            transform.Translate(Vector2.down * moveSpeed);
        }

        if (transform.position.x >= 235 && transform.position.y == 200)
        {
            transform.Translate(Vector2.right * moveSpeed);
        }
    }
}
