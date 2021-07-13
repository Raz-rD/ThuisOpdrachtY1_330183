using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RingMovement : MonoBehaviour
{
    //This script is purely to make the rings move forward
    //and destroy it when it hits the player    

    Rigidbody Rb;
    public float Force = 20f;
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Rb.AddForce(transform.forward * -Force);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);

        }
    }



    }
