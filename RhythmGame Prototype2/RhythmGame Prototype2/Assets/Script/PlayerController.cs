using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Usage: Control players that uses Unity Input manager.
//Intent: The controller can be used on multiple players.

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5;
    public int playerNum;
    public bool Keypressed;
    public float Threshold = 0.5f;

    public static int Score;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal" + playerNum);
        float z = Input.GetAxisRaw("Vertical" + playerNum);
        
        if (Mathf.Abs(x) >= Threshold && Keypressed == false)
        {
            playerRb.velocity = new Vector3(Mathf.Sign(x)*speed, 0, 0);
            Invoke("Stop", 1f/speed);
            Keypressed = true;
        }
        
        if (Mathf.Abs(z) >= Threshold && Keypressed == false)
        {
            playerRb.velocity = new Vector3(0, 0, Mathf.Sign(z)*speed);
            Invoke("Stop", 1f/speed);
            Keypressed = true;
        }


        if (Mathf.Abs(x) <= Threshold && Mathf.Abs(z) <= Threshold)
        {
            Keypressed = false;
        }
  
                        
    }

    void Stop()
    {
        playerRb.velocity = new Vector3(0, 0, 0);
    }
    
}
