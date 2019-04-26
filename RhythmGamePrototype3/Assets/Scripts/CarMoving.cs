using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{


    public int timeLimit;
    private int timeIndex;
    public float speed;
    public Vector3 CarMovement;
    private Vector3 StartPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        timeIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIndex == 0)
        {
            timeIndex = timeLimit;
            transform.position = StartPosition;
        }
        timeIndex--;
        transform.position += CarMovement * speed;
    }
}
