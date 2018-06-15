using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

namespace Assessment1
{
    public class OnNoChildren : MonoBehaviour
    {
        public UnityEvent onTriggered;

        // Fired off when another collider enters goal
        void Update()
        {
            if(transform.childCount == 0)
            {
                onTriggered.Invoke();
            }
        }
    }
}
