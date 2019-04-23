﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TweenCoroutine : MonoBehaviour
{
    [Header("Clock")]
    public AnimationCurve clockFallCurve;
    public float fallTime;
    public GameObject clock;
    public Vector3 clockEndPos;
    
    [Header("Baby")]
    public AnimationCurve babyFallCurve;
    public float babyfallTime;
    public GameObject baby;
    public Vector3 babyEndPos;

    [Header("StripeRotate")] 
    public List<float> wait;
    public List<StripeRotate> Stripe;
    
    private Vector3 clockStartPos;
    private Vector3 babyStartPos;

    //public static TweenCoroutine Tween;
    
    // Start is called before the first frame update
    void Start()
    {
        clockStartPos = clock.transform.position;
        babyStartPos = baby.transform.position;

        StartCoroutine(ClockFall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ClockFall()
    {
        float timer = 0;

        while (timer < fallTime)
        {
            timer += Time.deltaTime;
            clock.transform.position = Vector3.LerpUnclamped(clockStartPos, clockEndPos, clockFallCurve.Evaluate(timer / fallTime));
            yield return 0;
        }
        
        StartMoving();
        StartCoroutine(BabyFall());
    }
    
    IEnumerator BabyFall()
    {
        float timer = 0;

        while (timer < babyfallTime)
        {
            timer += Time.deltaTime;
            baby.transform.position = Vector3.LerpUnclamped(babyStartPos, babyEndPos, babyFallCurve.Evaluate(timer / babyfallTime));
            yield return 0;
        }
        
        //StartMoving();
    }

    public void StartMoving()
    {
        for (int i = 0; i < wait.Count - 3; i++)
        {
            //yield return new WaitForSeconds(wait[i]);
            Stripe[i].startMoving = true;
        }        
    }

    public void ReverseCommand()
    {
        for (int i = 0; i < wait.Count - 3; i++)
        {
            Stripe[i].reverse = true;
        }
    }

    public void ToSetting()
    {
        for (int i = 0; i < wait.Count - 4; i++)
        {
            Stripe[i + 4].startMoving = true;
        }
    }
    
    public void BackSetting()
    {
        for (int i = 0; i < wait.Count - 4; i++)
        {
            Stripe[i + 4].reverse = true;
        }
    }
}