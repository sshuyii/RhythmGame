using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    public GameObject TargetCamera;

    public FurnitureInteractor clockFI;

    public GameObject ladder;

    public static bool zooming;

    public bool startZoom;

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
    {
        if (clockFI.Activated && !startZoom)
        {
            startZoom = true;
            zooming = true;
        }
        
        if (zooming)
        {
            timer++;
            _camera.transform.localPosition =
                Vector3.LerpUnclamped(originalPosition, maxPosition, moving.Evaluate(timer / duration));
            _camera.orthographicSize = Mathf.LerpUnclamped(originalSize, maxSize, moving.Evaluate(timer / duration));
            
            //Activate the ladder too
            ladder.SetActive(true);
        }

        if (timer > duration && zooming)
        {
            zooming = false;
        }
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
