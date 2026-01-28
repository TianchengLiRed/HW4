using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("Jump")]
    private float Jumpforce = 4.0f;
    private int points;

    [Header("GameControl")]
    private bool isGameover = false;
    public UIController ui;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(!isGameover)
        Jump();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("gameover");
            isGameover = true;
            ui.End();
            
        }
        if (collision.gameObject.CompareTag("Points"))
        {
            points++;
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse);
        }
    }
}
