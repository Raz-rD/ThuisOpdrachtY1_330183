using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    public int playerPosition = 2;

    void Update()
    {   //make sure the position doesnt go below 1 and above 3
        playerPosition = Mathf.Clamp(playerPosition, 1, 3);

        //moving left to right
        if (Input.GetKeyDown("a"))
            {
                playerPosition = playerPosition - 1;
            }

            if (Input.GetKeyDown("d"))
            {
                playerPosition = playerPosition + 1;
            }

        //setting the positions
        if (playerPosition == 1)
        {
            transform.position = new Vector3(-22, 5, -15);
        }

        if (playerPosition == 2)
        {
            transform.position = new Vector3(0, 5, -15);
        }

        if (playerPosition == 3)
        {
            transform.position = new Vector3(22, 5, -15);
        }

    }
}
