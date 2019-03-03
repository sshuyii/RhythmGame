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
                
        transform.rotation = new Quaternion (0,  0, 0, 0);

        float x = Input.GetAxisRaw("Horizontal" + playerNum) * speed;
        float z = Input.GetAxisRaw("Vertical" + playerNum) * speed;
        playerRb.velocity = new Vector3(x, 0, -z);
        
    }
}
