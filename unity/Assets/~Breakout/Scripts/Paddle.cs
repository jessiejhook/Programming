using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Breakout
{
    
    public class Paddle : MonoBehaviour
    {
        public float movementSpeed = 20f;
        public Vector2[] directions =
        {
            new Vector2(-1, 1),
            new Vector2(1, 1)
        };
        // variable to see if we have fired
        public bool hasfired;

        private Ball currentBall;

        // Use this for initialization
        void Start()
        {
            currentBall = GetComponentInChildren<Ball>();

        }

        void Fire()
        {
            // detach as child
            currentBall.transform.SetParent(null);
            // generate random dir from list of directions
            Vector3 randomDir = directions[Random.Range(0, directions.Length)];
            // fire off ball in randomDirection
            currentBall.Fire(randomDir);
            // state that we have fired
            hasfired = true;

        }

        void CheckInput()
        {
            // if we have not fired, allow us to fire 
            if(!hasfired/* == false*/)
                // hasfired = true, !hasfired = false. Can also be written as hasfired = false
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Fire();
                }
            }
           
        }

        void Movement()
        {
            // get input on the horizontal axis
            float inputH = Input.GetAxis("Horizontal");
            // set force to direction (inputH to decide which direction)
            Vector3 force = transform.right * inputH;
            // apply movement speed to force
            force *= movementSpeed;
            // apply delta time to force
            force *= Time.deltaTime;
            // add force to position
            transform.position += force;
        }
        // Update is called once per frame
        void Update()
        {
            CheckInput();
            Movement();
        }
    }
}