using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class FurnitureInteractor : MonoBehaviour
{   
    
    public string EventID;
    public List<bool> BeatLoop;
    public float ShrinkDepth;
    public float RecoverRate;

    [Header("In Game Situation")] 
    public bool PlayerInPlace;

    public bool Resting = true;
    public Material RestingMat;
    public bool Waiting;
    public Material WaitingMat;
    public bool Demonstrating;
    public Material DemonstratingMat;
    public bool Checking;
    public Material CheckingMat;
    public bool Activated;
    
    
    private int BeatCount;
    private MeshRenderer rd;
    private Vector3 originalScale;
    private GameObject scoring;
    
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventID,BeatAnime);

        rd = transform.Find("Substance").GetComponent<MeshRenderer>();
        originalScale = transform.localScale;
        scoring = transform.Find("Scoring").gameObject;
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInPlace = true;
            rd.material = WaitingMat;        
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInPlace = false;
            //rd.material = RestingMat;        
        }
    }

    void BeatAnime(KoreographyEvent evt)
    {
        print("Beat " + BeatCount + " " + BeatLoop[BeatCount]);
        
        //Status check
        if (BeatCount == 0)
        {
            if (Resting)
            {
                if (PlayerInPlace)
                {
                    Resting = false;
                    Demonstrating = true;
                    rd.material = DemonstratingMat;
                }
            }
            else if (Demonstrating)
            {
                if (PlayerInPlace)
                {
                    Demonstrating = false;
                    Checking = true;
                    rd.material = CheckingMat;
                    scoring.SetActive(true);
                }
                else
                {
                    Resting = true;
                    Demonstrating = false;
                    rd.material = RestingMat;
                }
            }
            else if (Checking)
            {
                if (PlayerInPlace)
                {
                    
                }
                else
                {
                    Resting = true;
                    Checking = false;
                    rd.material = RestingMat;
                }
            }
        }
        
        //Beat Demonstration
        if (BeatLoop[BeatCount] && Demonstrating)
        {
            transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
            Invoke("Recover", RecoverRate);
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
