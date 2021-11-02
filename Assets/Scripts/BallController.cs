using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    Vector2 direction;
    public float speed;
    public Vector2 move;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        
        direction = Vector2.one.normalized;
    }

    private void Update() {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }

    // Menggerakkan bola dengan kecepatan tertentu
    private void FixedUpdate() {
        rigidBody2D.velocity = direction * speed;

        // Gerakan player dengan input
        rigidBody2D.MovePosition(rigidBody2D.position + move * speed * Time.fixedDeltaTime);
    }

    // Bola memantul ketika menabrak kotak diluar lingkaran
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }
        else if (collision.gameObject.CompareTag("SideWall"))
        {
            direction.x = -direction.x;
        }
    }


}
