using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicSetting : MonoBehaviour
{
    public GameObject graphic;

    public GameObject audio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        graphic.SetActive(true);
        audio.SetActive(false);
    }
}
