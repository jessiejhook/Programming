using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Breakout
{


    public class Ball : MonoBehaviour
    {
        public float speed = 5f; // speed that the ball travels 

        private Vector3 velocity; // velocity of the ball (direction x speed)

        public void Fire(Vector3 direction)
        {
            // Calculate velocity 
            velocity = direction * speed;

        }

        // detect collisions
        void OnCollisionEnter2D(Collision2D collision)
        
        {
            // grab contact point of collision 
            ContactPoint2D contact = collision.contacts[0];
            // calculate the reflection point of the ball using velocity and contact normal
            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            // calculate new velocity from reflection multiply by the same speed (velocity.magnitude)
            velocity = reflect.normalized * velocity.magnitude;

        }

       

        // Update is called once per frame
        void Update()
        {
            // moves ball using velocity and deltaTime
            transform.position += velocity * Time.deltaTime;
        }
    }
}
