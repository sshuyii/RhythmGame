using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepRatio : MonoBehaviour
{

    public Camera LetterboxBgCamera;
    public Camera MainCamera;

    // Use this for initialization
    void Start()
    {
        CalculateMainCameraDimensions();
    }


    public void CalculateMainCameraDimensions()
    {
        float sixteenBy9 = 16f / 9f;

        if (LetterboxBgCamera.aspect < sixteenBy9)
        {
            MainCamera.rect = new Rect(0f, (1.0f - LetterboxBgCamera.aspect / sixteenBy9) / 2.0f, 1.0f, LetterboxBgCamera.aspect / sixteenBy9);

        }
        else if (LetterboxBgCamera.aspect > sixteenBy9)
        {
            MainCamera.rect = new Rect((1.0f - sixteenBy9 / LetterboxBgCamera.aspect) / 2.0f, 0, sixteenBy9 / LetterboxBgCamera.aspect, 1.0f);
        }

    }
}
