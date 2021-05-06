using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField]
    public bool isPlayer1;

    [SerializeField]
    public bool isPlayer2;


    [SerializeField]
    public float speed;

    [SerializeField]
    public Rigidbody2D rb;

    private float movement;

    public Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if(isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else if(isPlayer2)
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
