using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    //Change between keyboard, or gyroscope controls.
    public bool useKeyboard;

    private Rigidbody _rb;
    private static float _speed = 35f;
    private float _dirX;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (!useKeyboard)
        {
            _dirX = Input.acceleration.x * _speed;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -250f, 250f), transform.position.y);
        }
    }

    private void FixedUpdate()
    {
        if (useKeyboard)
        {
            var moveHorizontal = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(moveHorizontal, 0f, 0f);
            _rb.AddForce(movement * _speed);
        }
        else
        {
            _rb.velocity = new Vector3(_dirX, 0f);
        }
    }

    //Caps the speed of the player.
    public void AdjustSpeed()
    {
        if (_speed <= 80f)
        {
            _speed += 2;
            //Debug.Log(speed);
        }
    }
}
