using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBound : MonoBehaviour
{
    public GameObject parent;

    //public bool active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(parent.activeInHierarchy);
    }
}
