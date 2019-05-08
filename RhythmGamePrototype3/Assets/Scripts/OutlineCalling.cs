using System.Collections;
using System.Collections.Generic;
using cakeslice;
using UnityEngine;

public class OutlineCalling : MonoBehaviour
{
    private cakeslice.Outline childOutline;
    //public bool playerOnLadder;
    public bool player1;
    public bool player2;
    public bool player3;
    

    // Start is called before the first frame update
    void Start()
    {
        childOutline = GetComponentInChildren<cakeslice.Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player1 == true || player2 == true || player3 == true)
        {
            childOutline.Enabling();
        }
        else if(player1 == false && player2 == false && player3 == false)
        {
            childOutline.Disabling();
        }
     
    }
    
   
}
