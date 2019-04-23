using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseoverExpand : MonoBehaviour
{
    public bool inflating;

    public float max = 1.03f;

    public float speedLimiter = 200f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!inflating && transform.localScale.x > 1)
        {
            transform.localScale -= Vector3.one / speedLimiter;
        }
    }

    private void OnMouseOver()
    {
        inflating = true;
        if (transform.localScale.x < max)
        {
            transform.localScale += Vector3.one / speedLimiter;
        }
        
    }

    private void OnMouseExit()
    {
        inflating = false;
    }
}
