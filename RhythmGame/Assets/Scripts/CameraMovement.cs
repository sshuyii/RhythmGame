using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float CameraRotationLimit;
    private int Timer = 100;

    
    private float CameraRotationYSum = 0;
    private float CameraRotationY = 0;
    private bool MoveLeft = true;
    private Transform CameraPivotTransform;
    
    private CameraStates _currentState;
    public enum CameraStates {MoveLeft, MoveRight, StayStill}


    // Start is called before the first frame update
    void Start()
    {

        transform.position = CameraPivotTransform.position;
    }

    void Awake()
    {
        CameraPivotTransform = GameObject.Find("CameraPivot").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotationYSum += CameraRotationY;
        
        print("CameraRotationYSum = " + CameraRotationYSum);
        print("Timer = " + Timer);
        
        if (CameraRotationYSum > CameraRotationLimit)
        {
            Timer--;
            if (Timer < 0)
            {
                _currentState = CameraStates.MoveLeft;
                Timer = 200;
            }
            else
            {
                _currentState = CameraStates.StayStill;
            }
            
        }
        else if (CameraRotationYSum < -CameraRotationLimit)
        {
            Timer--;
            if (Timer < 0)
            {
                _currentState = CameraStates.MoveRight;
                Timer = 200;
            }
            else
            {
                _currentState = CameraStates.StayStill;
            }
           
        }

        if (_currentState == CameraStates.MoveLeft)
        {


            CameraRotationY = -Time.deltaTime;
        }
        else if(_currentState == CameraStates.MoveRight)
        {
            CameraRotationY = Time.deltaTime;
        }
        else if (_currentState == CameraStates.StayStill)
        {
            CameraRotationY = 0;
        }

        transform.Rotate(0, CameraRotationY, 0, Space.World);
    }
    
    
}
