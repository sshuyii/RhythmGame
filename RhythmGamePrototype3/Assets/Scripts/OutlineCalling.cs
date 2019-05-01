using System.Collections;
using System.Collections.Generic;
using cakeslice;
using UnityEngine;

public class OutlineCalling : MonoBehaviour
{
    private Outline[] childOutlines;

    // Start is called before the first frame update
    void Start()
    {
        childOutlines = GetComponentsInChildren<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach (Outline c in childOutlines)
        {
            c.enabled = true;
        }
    }
}
