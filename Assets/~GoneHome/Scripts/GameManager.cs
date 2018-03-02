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
            // Get the current loaded scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Load that current scene
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}
