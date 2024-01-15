using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    
    public float moveSpeed = 5f;



    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(hInput, vInput);
        movement.Normalize();

        transform.Translate(movement * moveSpeed * Time.fixedDeltaTime);
    }
}
