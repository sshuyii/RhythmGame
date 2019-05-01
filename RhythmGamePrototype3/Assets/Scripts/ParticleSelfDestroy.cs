using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSelfDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SelfDestroy", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
