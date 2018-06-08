using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean Code: CTRL + K + D (in that order)

// {} - Braces
// [] - Brackets
// () - Parenthesis
namespace Asteroids
{
    public class Moving : MonoBehaviour
    {

        // Member Variables
        public float rotationSpeed = 20f; // units to travel per second
        public float movementSpeed = 360f; // amount of rotation per second
        private Rigidbody2D rigid; // reference to attached Rigidbody2D

        // use this for initialization 
        void Start()
        {
            // grab reference to rigidbody2D component
            // NOTE: it gets this from the GameObject this script is attached to
            rigid = GetComponent<Rigidbody2D>();

        }

        void Movement()
        {
            // Move up
            if (Input.GetKey(KeyCode.UpArrow))
            {
                // Move the player up by movementSpeed
                //Vector3 position = transform.position;
                //position.y += movementSpeed * Time.deltaTime;
                //transform.position = position;
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }

            // Move down
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
            }
        }

        void Rotation()
        {
            // Rotate Right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }

            // Rotate Left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);

            }
        }

        // TASK: Make a 'Rotation()' function and put rotation code in it

        // Update is called once per frame
        void Update()
        {
            // Call 'Movement()' function
            Movement();

            // Call 'Rotation()' function
            Rotation();
        }
    }
}
