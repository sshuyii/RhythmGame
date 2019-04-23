using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public TweenCoroutine Tween;
    public GameObject graphic;

    public GameObject audio;
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
        Tween.BackSetting();
        Tween.StartMoving();
        graphic.SetActive(false);
        audio.SetActive(false);
    }
}
