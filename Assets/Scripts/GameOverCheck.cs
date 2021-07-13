using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverCheck : MonoBehaviour
{
    public Text gameOverText;
    public bool timerOn = false;
    public float CountdownTimer = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //send game back to menu after a couple seconds
        if (timerOn == true)
        {
            CountdownTimer -= 0.09f;
        }

        if (CountdownTimer <= 0)
        {
            SceneManager.LoadScene("Menu");
            Time.timeScale = 1;
        }
    }
    //end game when you die
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "ScoreRing(Clone)")
        {
            gameOverText.text = "Game Over!";
            Time.timeScale = 0;
            timerOn = true;
        }

    }

}


