using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class ColliderDestroy : MonoBehaviour
{
    private float Timer;
    private MeshRenderer rd;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.2f, 1f, 0.2f);
        rd = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += 1;

        //collider持续扩大
//        if (transform.localScale.x < 1)
//        {
//            transform.localScale += new Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);
//            print("Expanding");
//        }
        
        //collider一下一下扩大
        if (Timer < 30)
        {
            transform.localScale = new Vector3(0.2f, 1f, 0.2f);
        }
        else if(Timer < 60)
        {
            transform.localScale = new Vector3(0.5f, 1f, 0.5f);
        }
        else if(Timer < 90)
        {
            transform.localScale = new Vector3(0.8f, 1f, 0.8f);
        }  
        else if(Timer < 120)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        
        if (Timer > 140)
        {
            Koreographer.Instance.UnregisterForAllEvents(GetComponent<RhythmControllerSnap>());
            Destroy(gameObject);
            rd.enabled = false;
        }
    }
}
