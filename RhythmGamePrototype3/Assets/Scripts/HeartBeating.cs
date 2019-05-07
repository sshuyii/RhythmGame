using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
//using Rewired.Utils.Platforms.OSX;
using SonicBloom.Koreo;


public class HeartBeating : MonoBehaviour
{
    
    
    public FurnitureInteractor furnitureInteractor;
    
    private Transform _StrokeTransform;
    private Transform _FullTransform;

    private Vector3 punch;
    private float duration = 0.2f;
    private int vibrato = 1;
    private float elasticity = 1f;

    public string FurnitureName;

    private GameObject Stroke;
    private GameObject Full;

    private CanvasRenderer rdFull;
    private CanvasRenderer rdStroke;
    private Vector3 CameraLookDirection;

    private GameObject Smoke;


    //public bool _readyPunch;
    
    // Start is called before the first frame update
    void Start()
    {
        //Koreographer.Instance.RegisterForEventsWithTime("UIController",TestOffset);
        
        Stroke = GameObject.Find(FurnitureName + "UI/Stroke");
        Full = GameObject.Find(FurnitureName + "UI/Full");

        rdStroke = Stroke.GetComponent<CanvasRenderer>();
        rdFull = Full.GetComponent<CanvasRenderer>();

        CameraLookDirection = Camera.main.transform.forward;

        
        _StrokeTransform = Stroke.GetComponent<Transform>();
        _FullTransform = Full.GetComponent<Transform>();
        
        Smoke = GameObject.Find("/SmokeParticle");
    }

    // Update is called once per frame
    void Update()
    {
        CameraLookDirection = Camera.main.transform.forward;

        //让UI面向镜头
//        Full.transform.LookAt(Camera.main.transform.position);	
//        Stroke.transform.LookAt(Camera.main.transform.position);	

        Quaternion rotation = Quaternion.LookRotation(CameraLookDirection, Vector3.up);

        Stroke.transform.rotation = rotation;
        Full.transform.rotation = rotation;

        
        punch = new Vector3 (0.5f, 0.5f, 0.5f);

        if (furnitureInteractor.readyPunch)
        {
            furnitureInteractor.readyPunch = false;
            _StrokeTransform.DOPunchScale(punch, duration, vibrato, elasticity);
            _FullTransform.DOPunchScale(punch, duration, vibrato, elasticity);
        }


    }
}
