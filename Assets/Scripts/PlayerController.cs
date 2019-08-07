using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Change between keyboard, or gyroscope controls.
    public bool useKeyboard;

    private Rigidbody rb;
    private static float speed = 35f;
    private float _dirX;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!useKeyboard)
        {
            _dirX = Input.acceleration.x * speed;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -250f, 250f), transform.position.y);
        }
    }

    void FixedUpdate()
    {
        if (useKeyboard)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
            rb.AddForce(movement * speed);
        }
        else
        {
            rb.velocity = new Vector3(_dirX, 0f);
        }
    }

    //Caps the speed of the player.
    public void AdjustSpeed()
    {
        if (speed <= 80f)
        {
            speed += 2;
            //Debug.Log(speed);
        }
    }
}
