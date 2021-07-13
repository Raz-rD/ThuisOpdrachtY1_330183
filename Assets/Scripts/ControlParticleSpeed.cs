using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlParticleSpeed : MonoBehaviour
{
    ScoreCounter ScoreScript;
    private ParticleSystem ps;
    void Start()
    {
        ScoreScript = GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreCounter>();
        ps = GetComponent<ParticleSystem>();
    }

    
    void Update()
    {
        //this makes the game visually faster the more points you have (to visually display difficulty levels)
        if (ScoreScript.Score == 5)
        {
            var particleSpeed = ps.main;
            particleSpeed.startSpeed = 20f;
            var particleAmmount = ps.emission;
            particleAmmount.rateOverTime = 50f;
        }
        if (ScoreScript.Score == 10)
        {
            var particleSpeed = ps.main;
            particleSpeed.startSpeed = 30f;
            var particleAmmount = ps.emission;
            particleAmmount.rateOverTime = 65f;
        }
        if (ScoreScript.Score == 25)
        {
            var particleSpeed = ps.main;
            particleSpeed.startSpeed = 40f;
            var particleAmmount = ps.emission;
            particleAmmount.rateOverTime = 80f;
        }
        if (ScoreScript.Score == 50)
        {
            var particleSpeed = ps.main;
            particleSpeed.startSpeed = 55f;
            var particleAmmount = ps.emission;
            particleAmmount.rateOverTime = 90f;
        }
    }
}
