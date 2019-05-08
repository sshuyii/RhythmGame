using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    // USAGE: Main camera
    // FUNCTION: Make the camera zoom in and out

    public AnimationCurve moving;
    private Vector3 maxPosition;
    public float maxSize;
    private Vector3 originalPosition;
    private float originalSize;
    public float duration;
    private float timer;
    //public GameObject EnvironmentalLight;
    //public GameObject YardLight;
    
    public GameObject TargetCamera;

    public FurnitureInteractor clockFI;
    public FurnitureInteractor pianoFI;


    public GameObject ladder;

    public static bool zooming;

    private int pianoZoom = 0;

    public bool startZoom;
    private bool pianoEnabled = false;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    void Start()
    {
        originalPosition = _camera.transform.localPosition;
        originalSize = _camera.orthographicSize;
        timer = 0;
        maxPosition = TargetCamera.transform.localPosition;
//        StartCoroutine(myCameraMoveBack());
    }

    // Update is called once per frame
    void Update()
    {   //zoom out when game starts
        if (clockFI.Activated && !startZoom)
        {
            startZoom = true;
            zooming = true;
        }
        
        if (zooming)
        {
            ZoomInOrOut(originalPosition, maxPosition, originalSize, maxSize);
            
            //Activate the ladder too
            ladder.SetActive(true);
        }

        if (timer > duration && zooming)
        {
            zooming = false;
            timer = 0;
            //EnvironmentalLight.SetActive(true);
            //YardLight.SetActive(true);
            
        }
        else if(timer > duration && pianoZoom == 1)
        {
            pianoZoom = 2;
            timer = 0;
        }
        
         
        //zoom in when game ends

        if (pianoFI.Activated == true && timer <= duration)
        {
            ZoomInOrOut(originalPosition, maxPosition, originalSize, maxSize);
            ladder.SetActive(true);
        }
        else if (pianoFI.playersInvolved.Count == 3 && timer <= duration && pianoEnabled == false)
        {
            pianoZoom = 1;
            pianoEnabled = true;


        }

        if (pianoZoom == 1)
        {
            ZoomInOrOut(maxPosition, originalPosition, maxSize, originalSize);
            ladder.SetActive(false);
        }
        
    }
    
    //把zoom in zoom out写成单独的函数

    void ZoomInOrOut(Vector3 currentPosition, Vector3 targetPosition, float currentSize, float targetSize)
    {
        timer++;
        _camera.transform.localPosition =
            Vector3.LerpUnclamped(currentPosition, targetPosition, moving.Evaluate(timer / duration));
        _camera.orthographicSize = Mathf.LerpUnclamped(currentSize, targetSize, moving.Evaluate(timer / duration));
    }
    
    
    
    
    
    
    
    
/*

    IEnumerator myCameraMoveIn()
    {
        float timer = 0f;
        while (timer < duration)
        {
            timer++;
            Camera.main.transform.localPosition =
                Vector3.LerpUnclamped(originalPosition, maxPosition, moving.Evaluate(timer / duration));
            Camera.main.orthographicSize = Mathf.LerpUnclamped(originalSize, maxSize, moving.Evaluate(timer / duration));
            yield return 0;
        }
    }

    IEnumerator myCameraMoveBack()
    {

        float timer = 0f;
        while (timer < duration)
        {
            timer++;
            Camera.main.transform.localPosition =
                Vector3.LerpUnclamped(maxPosition, originalPosition, moving.Evaluate(timer / duration));
            Camera.main.orthographicSize = Mathf.LerpUnclamped(maxSize, originalSize, moving.Evaluate(timer / duration));
            yield return 0;
        }
    }

    public void cameraZoomOut()
        {
            StartCoroutine(myCameraMoveBack());
        }*/
}
