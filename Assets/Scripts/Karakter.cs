using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    Rigidbody2D rb;
    float rotateSpeed = 0;
    
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {


            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(new Vector2(25, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(new Vector2(-15, 0));
            }
        }
    }
    

