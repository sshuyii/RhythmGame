using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    //这个script要放在player下面
    public GameObject TopTrigger;
    public GameObject BottomTrigger;

    private int _transport = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider Other)
    {
        
        if (Other.CompareTag("DownStairs") || Other.CompareTag("UpStairs"))
        {
            print("OnTriggerEnter");

            _transport += 1;
            
            if (_transport == 1)
            {
                if (Other.CompareTag("UpStairs"))
                {
                    transform.position = BottomTrigger.transform.position;

                }
                else if (Other.CompareTag("DownStairs"))
                {
                    transform.position = TopTrigger.transform.position;
 
                }
                
            }
            
        }
        
        if (Other.CompareTag("SetToFalse"))
        {
            print("OnTriggerExit");
            _transport = 0;
        }
      
    }
    
    
}
