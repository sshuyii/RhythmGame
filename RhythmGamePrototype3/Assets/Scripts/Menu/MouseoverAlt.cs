using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseoverAlt : MonoBehaviour
{
    public GameObject initial;

    public GameObject alt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseOver()
    {
        initial.SetActive(false);
        alt.SetActive(true);
        
    }

    private void OnMouseExit()
    {
        initial.SetActive(true);
        alt.SetActive(false);
    }
}
