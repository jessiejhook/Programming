using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assessment1
{
    public class GameManager : MonoBehaviour
    {
        // Switch to next level when this function runs
        public void NextLevel()
        {
            // Get active scene
            Scene currentScene = SceneManager.GetActiveScene();
            // Load the next scene up using buildIndex
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }

        public void LoadFirstScene()
        // will load the first scene (0) in build settings
        {
            SceneManager.LoadScene(0);
        }
    }
}
