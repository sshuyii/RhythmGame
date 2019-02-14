using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Usage: Control players that uses Unity Input manager.
//Intent: The controller can be used on multiple players.

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 6;
    public int playerNum;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal" + playerNum) * speed;
        //print("Got x input" + x);
        float z = Input.GetAxis("Vertical" + playerNum) * speed;
        //print("Got y input");
        playerRb.velocity = new Vector3(x, 0, -z);
    }
}
