using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace GoneHome
{
    public class Trigger : MonoBehaviour
    {
        public UnityEvent onTriggered;
        
        // Fired off when another collider enters goal
        void OnTriggerEnter(Collider other)
        {
            // Detect if other collider is player
            if (other.name.Contains("Player") &&
                transform.childCount == 0)
            {
                // Fire off our event (onTriggered)
                onTriggered.Invoke();
            }
        }
    }
}
