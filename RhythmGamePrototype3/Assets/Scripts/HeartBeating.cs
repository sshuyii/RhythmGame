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

    private bool particleExist;
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
    private bool activated = false;
    private float timer;

    private bool activatedDouble = false;
    private GameObject starParticle;

    //public bool _readyPunch;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        //Koreographer.Instance.RegisterForEventsWithTime("UIController",TestOffset);
        starParticle = Resources.Load<GameObject>("starSplash");
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

        if (furnitureInteractor.Activated == true && activatedDouble == false)
        {
            activated = true;
            activatedDouble = true;
        }

        if (activated == true)
        {
            timer += Time.deltaTime;
        }
        
        
        if (furnitureInteractor.readyPunch && activated == false)
        {
            punch = new Vector3 (0.5f, 0.5f, 0.5f);
            print("punch ==================true");

            furnitureInteractor.readyPunch = false;
            _StrokeTransform.DOPunchScale(punch, duration, vibrato, elasticity);
            _FullTransform.DOPunchScale(punch, duration, vibrato, elasticity);
        }
        else if (activated == true && timer > 0.8f)
        {
//            timer++;
//            //activated = false;
//            punch = new Vector3 (0.5f, 0.5f, 0.5f);
//            print("activated ==================true");
//            elasticity = 0.2f;
//            vibrato = 50;
//            duration = 0.2f;
//
//            _StrokeTransform.DOPunchScale(punch, duration, vibrato, elasticity);
//
//            _FullTransform.DOPunchScale(punch, duration, vibrato, elasticity);



            timer += Time.deltaTime;
            if (timer < 1.2 && timer > 1.1)
            {
                _StrokeTransform.localScale =
                    Vector3.Lerp(_StrokeTransform.localScale, new Vector3(0.2f, 0.2f, 0.2f), Time.deltaTime * 10);
                _FullTransform.localScale =
                    Vector3.Lerp(_StrokeTransform.localScale, new Vector3(0.2f, 0.2f, 0.2f), Time.deltaTime * 10);
            }
            else if (timer > 1.2 && timer < 1.4)
            {
                _StrokeTransform.localScale =
                    Vector3.Lerp(_StrokeTransform.localScale, new Vector3(2f, 2f, 2f), Time.deltaTime * 10);
                _FullTransform.localScale =
                    Vector3.Lerp(_StrokeTransform.localScale, new Vector3(2f, 2f, 2f), Time.deltaTime * 10);
            }
            else if (timer < 1.6 && timer > 1.4)
            {
                _StrokeTransform.localScale =
                    Vector3.Lerp(_StrokeTransform.localScale, new Vector3(0.2f, 0.2f, 0.2f), Time.deltaTime * 10);
                _FullTransform.localScale =
                    Vector3.Lerp(_StrokeTransform.localScale, new Vector3(0.2f, 0.2f, 0.2f), Time.deltaTime * 10);
            }
            else if (timer > 1.6 && timer < 2)
            {
                if(particleExist == false)
                {
                    particleExist = true;
                    Instantiate(starParticle, _StrokeTransform.position, Quaternion.identity);
                }                //Destroy(_myParticle, 0.4f);
                Stroke.SetActive(false);
                Full.SetActive(false);
            }
           
          
        }


    }
}
