using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Assessment1
{
    public class Goal : MonoBehaviour
    {
        public bool isAdvancing = false;
        public UnityEvent onTriggered;
        public void CanAdvance(bool canAdvance)
        // can advance through the goal to the next scene
        {
            isAdvancing = canAdvance;
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            // if isAdvancing && col.name.Contains("Player")
            // Invoke onTriggered
            if (col.name.Contains("Player") && isAdvancing)
            {
                // Fire off our event (onTriggered)
                onTriggered.Invoke();
            }
        }
    }
}