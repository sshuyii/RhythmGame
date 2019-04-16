using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class HeartBeating : MonoBehaviour
{
    public FurnitureInteractor FurnitureInteractor;
    
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


    public bool _readyPunch;
    
    // Start is called before the first frame update
    void Start()
    {
        Stroke = GameObject.Find(FurnitureName + "UI/Stroke");
        Full = GameObject.Find(FurnitureName + "UI/Full");

        rdStroke = Stroke.GetComponent<CanvasRenderer>();
        rdFull = Full.GetComponent<CanvasRenderer>();

        rdStroke.SetAlpha(0);
        rdFull.SetAlpha(0);

        
        _StrokeTransform = Stroke.GetComponent<Transform>();
        _FullTransform = Full.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        punch = new Vector3 (0.5f, 0.5f, 0.5f);

        if (_readyPunch == true)
        {
            _readyPunch = false;
            _StrokeTransform.DOPunchScale(punch, duration, vibrato, elasticity);
            _FullTransform.DOPunchScale(punch, duration, vibrato, elasticity);
            
        }
    }
}
