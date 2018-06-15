using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Play()
    // makes functioning Play button - will begin the game
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    // will exit the application - only applicable with builds
    {
        Application.Quit();
    }
}
