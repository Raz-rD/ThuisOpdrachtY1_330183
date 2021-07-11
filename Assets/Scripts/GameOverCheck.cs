using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverCheck : MonoBehaviour
{
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //end game when you die
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "ScoreRing(Clone)")
        {
            gameOverText.text = "Game Over!";
            Time.timeScale = 0;
        }

    }

}


