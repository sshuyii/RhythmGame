using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyFollow : MonoBehaviour
{

    public GameObject _myPlayer;
    private Vector3 offset;
    
    
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - _myPlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _myPlayer.transform.position + offset;
    }
}
