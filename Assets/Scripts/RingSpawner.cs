using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    public float spawnTimer = 3f;
    private float spawnRate = 0.009f;
    private int locationDecider;
    public float ParticleSpeed = 15.0F;
    public GameObject ringPrefab;
    public Transform player;
    ScoreCounter ScoreScript;


    private Vector3 location1;
    private Vector3 location2;
    private Vector3 location3;

    // Start is called before the first frame update
    void Start()
    {
        //finds the score script so i can use the score to determine things
        ScoreScript = GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreCounter>();
        //sets locations to spawn rings
        location1 = new Vector3(-22, 5, 30);
        location2 = new Vector3(0, 5, 30);
        location3 = new Vector3(22, 5, 30);
    }

        
    // Update is called once per frame
    void Update()
    {
        //timer for when to spawn
        spawnTimer -= spawnRate;

        if (spawnTimer <= 0)
        {
            spawnRing();
            spawnTimer = 3;
        }

        //makes it harder the more score you get
        if (ScoreScript.Score == 5)
        {
            spawnRate = 0.02f;
        }
        if (ScoreScript.Score == 10)
        {
            spawnRate = 0.03f;
        }
        if (ScoreScript.Score == 25)
        {
            spawnRate = 0.04f;
        }
        if (ScoreScript.Score == 50)
        {
            spawnRate = 0.055f;
        }

    }
    //pick a random location
    void spawnRing()
    {
        locationDecider = Random.Range(1, 4);

        if (locationDecider == 1)
        {
            Instantiate(ringPrefab, location1, transform.rotation);
        }
        
        if (locationDecider == 2)
        {
            Instantiate(ringPrefab, location2, transform.rotation);
        }

        if (locationDecider == 3)
        {
            Instantiate(ringPrefab, location3, transform.rotation);
        }
    }

        
        
}
