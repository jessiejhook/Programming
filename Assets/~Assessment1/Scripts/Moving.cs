using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

namespace Assessment1
{



    public class Moving : MonoBehaviour
    {

        // Member Variables
        public float rotationSpeed = 20f; // units to travel per second
        public float movementSpeed = 360f; // amount of rotation per second
        public Text countText; // reference to score in UI
        public Text winText;
        private Rigidbody2D rigid; // reference to attached Rigidbody2D
        private int count; // score count

        // Use this for initialization
        void Start()
        {
            // grab reference to rigidbody2D component
            // NOTE: it gets this from the GameObject this script is attached to
            rigid = GetComponent<Rigidbody2D>();

            // set score to 0
            count = 0;

            // refers to count + count.tostring
            SetCountText();

            // refers to setting the end of game message
            winText.text = "";

        }
        void Movement()
        {

            // Move the player by movementSpeed
            //Vector3 position = transform.position;
            //position.y += movementSpeed * Time.deltaTime;
            //transform.position = position;


            // Move Forward
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

            }

            // Move backwards
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

        }

        void Rotation()
        {
            // Rotate Right
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }

            // Rotate Left
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);

            }
        }





        // Update is called once per frame
        void Update()
        {
            // Call 'Movement()' function
            Movement();

            // Call 'Rotation()' function
            Rotation();
        }


        void OnTriggerEnter2D(Collider2D col)
        // Triggering "bubbles" to collect when player collides with them
        {
            if (col.gameObject.CompareTag("Bubbles"))
            {
                col.gameObject.SetActive(false);
                // deactivates the game object "bubbles"
                count = count + 1;
                // adds value of 1 to the score as each bubble is collected
                SetCountText();


            }
        }

        void SetCountText()
        {
            countText.text = "Count: " + count.ToString();
            if (count >=3)
            {
                winText.text = "Well Done!"; // sets end game message
            }
        }
    }
}

