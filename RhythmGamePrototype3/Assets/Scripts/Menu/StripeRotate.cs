using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StripeRotate : MonoBehaviour
{
    public AnimationCurve stripeRotateCurve;
    public bool startMoving;
    public bool reverse;
    public int modulator = 1;
    public Vector3 maxAngle;

    public float timeRequired;

    private Vector3 originalAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        originalAngle = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (startMoving)
        {
            startMoving = false;
            print("Stripe Move!");
            StartCoroutine(Rotate());
        }
        
        if (reverse)
        {
            reverse = false;
            print("Stripe Reverse!");
            StartCoroutine(Reverse());
        }
    }

    IEnumerator Rotate()
    {
        float timer = 0;
        
        while (timer < timeRequired)
        {
            timer += Time.deltaTime;
            transform.localEulerAngles = Vector3.LerpUnclamped(originalAngle, maxAngle, stripeRotateCurve.Evaluate(timer / timeRequired));
            yield return 0;
        }
    }

    IEnumerator Reverse()
    {
        float timer = 0;
        
        while (timer < timeRequired)
        {
            timer += Time.deltaTime;
            transform.localEulerAngles = Vector3.LerpUnclamped(-maxAngle * modulator, originalAngle, - stripeRotateCurve.Evaluate(timer / timeRequired) * modulator);
            yield return 0;
        }
    }
}
