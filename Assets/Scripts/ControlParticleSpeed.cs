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

    // Update is called once per frame
    void Update()
    {
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
