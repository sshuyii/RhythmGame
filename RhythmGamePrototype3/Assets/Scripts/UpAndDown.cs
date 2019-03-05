using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    //这个script要放在player下面
    public GameObject TopTrigger1;
    public GameObject BottomTrigger1;
    public GameObject TopTrigger2;
    public GameObject BottomTrigger2;
    

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
                    if(Other.gameObject == BottomTrigger1)
                    {
                        transform.position = TopTrigger1.transform.position;
                    }
                    else if(Other.gameObject == BottomTrigger2)
                    {
                        transform.position = TopTrigger2.transform.position;
                    }
                }
                else if (Other.CompareTag("DownStairs"))
                {
                    if(Other.gameObject == TopTrigger1)
                    {
                        transform.position = BottomTrigger1.transform.position;
                    }
                    else if(Other.gameObject == TopTrigger2)
                    {
                        transform.position = BottomTrigger2.transform.position;
                    }
 
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
