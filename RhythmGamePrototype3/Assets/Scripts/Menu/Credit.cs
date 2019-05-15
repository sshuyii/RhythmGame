using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public TweenCoroutine Tween;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnMouseDown()
    {
        print("To Credit");
        Tween.ReverseCommand();
        Tween.ToCredit();
        Tween.ClockLift();
    }
}
