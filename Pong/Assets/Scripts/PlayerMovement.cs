using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private bool isPlayer1;
    private Rigidbody2D rb;
    private float movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");   
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
           
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);

        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -4.2f, 4.2f);
        transform.position = clampedPosition;
        
    }
}
