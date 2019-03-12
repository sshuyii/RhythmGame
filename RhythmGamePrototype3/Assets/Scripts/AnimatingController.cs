using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatingController : MonoBehaviour
{

    public bool _activate;
    private void OnTriggerEnter(Collider other)
    {
        _activate = true;
    }
   
    private void OnTriggerExit(Collider other)
    {
        _activate = false;
    }
}
