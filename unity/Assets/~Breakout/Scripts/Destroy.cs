using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public static int score;
    public Text scoreText;

    void Start()
    {
        score = 0;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Blocks")
        {
            Destroy(coll.gameObject);
            score++;
            scoreText.text = score.ToString();
            // if ball collides with game object "Blocks", destroy game object "Blocks"
        }
        if (coll.gameObject.tag == "Reset")
        {
            SceneManager.LoadScene(3);
        }
    }
}
