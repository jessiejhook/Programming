using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{



    public class AsteroidSpawner : MonoBehaviour
    {
        public GameObject[] asteroidPrefabs; // array of prefabs to spawn
        public float spawnRate = 1f; // rate of spawn
        public float spawnRadius = 5f; // radius of spawn

        void Spawn()
        {
            //randomise a position
            Vector3 rand = Random.insideUnitSphere * spawnRadius;
            // cancel the z axis on position
            rand.z = 0f;
            // generate position using rand
            Vector3 position = transform.position + rand;
            //generate random index into prefab array
            int randIndex = Random.Range(0, asteroidPrefabs.Length);
            // get random asteroid
            GameObject randAsteroid = asteroidPrefabs[randIndex];
            // clone random asteroid
            GameObject clone = Instantiate(randAsteroid);
            // set clone's position
            clone.transform.position = position;
        }

        // Use this for initialization
        void Start()
        {
            // calls a function a specified amount of times
            InvokeRepeating("Spawn", 0, spawnRate);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
