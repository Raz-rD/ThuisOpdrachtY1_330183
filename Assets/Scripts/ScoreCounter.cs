using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    public int Score;
    void Update()
    {
        scoreText.text = Score.ToString();
    }
 
    // Check collision and add a point
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "ScoreRing(Clone)")
        {
            Score = Score + 1;

        }

    }
    
}
