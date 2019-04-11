using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class HeartBeating : MonoBehaviour
{
    private Transform _myTransform;
    private Vector3 punch;
    private float duration = 0.3f;
    private int vibrato = 1;
    private float elasticity = 1f;

    public bool _readyPunch;
    
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        punch = new Vector3 (0.5f, 0.5f, 0.5f);

        if (_readyPunch == true)
        {
            _myTransform.DOPunchScale(punch, duration, vibrato, elasticity);
            _readyPunch = false;
            print("_readyPunch = " + _readyPunch);
        }
    }
}
