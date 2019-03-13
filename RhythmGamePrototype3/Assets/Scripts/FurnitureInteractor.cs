﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using UnityEditor;
using UnityEngine.UI;

public class FurnitureInteractor : MonoBehaviour
{   
    [Header("Beat Control")]
    public string EventID;
    public List<bool> BeatLoop;
    
    [Header("Animation")]
    //public float ShrinkDepth;
   // public float RecoverRate;
    public GameObject Furniture;
    private Animator _anim;
    
    [Header("In Game Situation")] 
    public bool PlayerInPlace;
    public bool Resting = true;
    //public Material RestingMat;
    public bool Waiting;
    //public Material WaitingMat;
    public bool Demonstrating;
    //public Material DemonstratingMat;
    public bool Checking;
    //public Material CheckingMat;
    public bool Activated;
    //public Material ActivatedMat;
    public GameObject spotLight;
    public GameObject player1SpotLight;
    public bool yourTurn;
    public bool myTurn;
    public bool playerSpotLightOn;

    //以下是新加的
    //public GameObject _light;
    private AudioSource _audioSource;
    

    [Header("Checking")] 
    public int perfect;
    public int miss;
    public Text perfectText;
    public Text missText;
    public int RequiredPerfect;
    public int BeatCount;
    
    private MeshRenderer rd;
    private Vector3 originalScale;
    private GameObject scoring;
    
    //public GameObject _collider;//设为通用的，在awake function里自行寻找
    
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventID,BeatAnime);

        //rd = Furniture.GetComponent<MeshRenderer>();
       
        //rd = Furniture.GetComponent<MeshRenderer>();
        //新加
        _audioSource = GetComponent<AudioSource>();
        _anim = Furniture.GetComponent<Animator>();
        spotLight = transform.Find("SpotLight").gameObject;
        

            
        originalScale = transform.localScale;
        scoring = transform.Find("Scoring").gameObject;

        foreach (var Beat in BeatLoop)
        {
            if (Beat) RequiredPerfect++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInPlace = true;
            other.GetComponent<PlayerController>().furnitureInteractor = this;
            player1SpotLight = other.transform.Find("SpotLight").gameObject;
            //_light.SetActive(true);

            if (Resting)
            {
                //rd.material = WaitingMat;                
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInPlace = false;
            _anim.SetBool("IsMoving", false);
            //player1SpotLight = null;
            other.GetComponent<PlayerController>().furnitureInteractor = null;

            //_light.SetActive(false);
        }
    }

    void BeatAnime(KoreographyEvent evt)
    {
        //print("Beat " + BeatCount + " " + BeatLoop[BeatCount]);
        
        
        //聚光灯效果
        if (BeatCount == 7)
        {
            if (PlayerInPlace)
            {
                if (Demonstrating)
                {
                    spotLight.SetActive(false);
                    if(player1SpotLight)player1SpotLight.SetActive(true);
                }
                else if (Resting)
                {
                    spotLight.SetActive(true);
                    if(player1SpotLight)player1SpotLight.SetActive(false);
                }
                else if (Checking)
                {
                    spotLight.SetActive(true);
                    if(player1SpotLight)player1SpotLight.SetActive(false);
                }            
            }
            else
            {
                spotLight.SetActive(false);
                if(player1SpotLight)player1SpotLight.SetActive(false);
            }

        }
        
        //Status check
        if (BeatCount == 0)
        {
            if (Resting)
            {
                if (PlayerInPlace)
                {
                    Resting = false;
                    Demonstrating = true;
                    //rd.material = DemonstratingMat;
                    _anim.SetBool("IsMoving", true);
                    
                }
                else
                {
                    //rd.material = RestingMat;
                }
            }
            else if (Demonstrating)
            {
                Demonstrating = false;
                if (PlayerInPlace)
                {
                    Checking = true;
                    //rd.material = CheckingMat;
                    scoring.SetActive(true);

                }
                else
                {
                    Resting = true;
                    //rd.material = RestingMat;
                }
            }
            else if (Checking)
            {
                scoring.SetActive(false);

                Checking = false;
                if (PlayerInPlace)
                {
                    if (perfect == RequiredPerfect && miss == 0)
                    {
                        Activated = true;
                        //rd.material = ActivatedMat;    
                        
                    }
                    else
                    {
                        Demonstrating = true;
                        perfect = 0;
                        miss = 0;
                        perfectText.text = "Perfect: ";
                        missText.text = "Miss: ";
                        //rd.material = DemonstratingMat;
                    }
                }
                else
                {
                    Resting = true;
                    //rd.material = RestingMat;
                }
            }
        }
        
        //Beat Demonstration
        if (BeatLoop[BeatCount] && (Demonstrating || Activated))
        {
            //transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
            //用animation取代
            
            
            
            
            _audioSource.Play();

            //Invoke("Recover", RecoverRate);
        }
        
        //To next beat
        BeatCount = (BeatCount + 1) % BeatLoop.Count;
    }

    void Recover()
    {
        transform.localScale = originalScale;
    }
    
    // Update is called once per frame
    void Update()
    {

    }
    
}
