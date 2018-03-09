using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace GoneHome
{

    public class GameManager : MonoBehaviour
    {
        // Switches to next scene when called
        public void NextLevel()
        {
            // Get the current loaded scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Load the one next to it (using buildIndex)
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        } 

        // Restart that gosh darn level
        public void ResetLevel()
        {
            // Find all enemies within the game 
            FollowEnemy[] enemies = FindObjectsOfType<FollowEnemy>();
            // Loop through all of them 
           for (int i = 0; i < enemies.Length; i++)
            {
                // reset them
                enemies[i].Reset();
            }

            // Find the player
            Player player = FindObjectOfType<Player>();
            // Reset the player
            player.Reset(); 
        }
    }
}
