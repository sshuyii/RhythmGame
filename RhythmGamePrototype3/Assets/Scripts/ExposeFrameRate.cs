using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExposeFrameRate : MonoBehaviour
{
    public Text frameRate;

    // Update is called once per frame
    void Update()
    {
        frameRate.text = (1f/Time.deltaTime).ToString();
    }
}
