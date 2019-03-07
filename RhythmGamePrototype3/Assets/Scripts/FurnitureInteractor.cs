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
    public float ShrinkDepth;
    public float RecoverRate;
    public GameObject Furniture;
    
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
    public Material ActivatedMat;

    //以下是新加的
    public GameObject _light;
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
    
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventID,BeatAnime);

        //rd = Furniture.GetComponent<MeshRenderer>();
       
        rd = transform.Find("Substance").GetComponent<MeshRenderer>();
        //新加
        _audioSource = transform.Find("Substance").GetComponent<AudioSource>();
            
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
            _light.SetActive(true);

            if (Resting)
            {
                rd.material = WaitingMat;                
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInPlace = false;
            other.GetComponent<PlayerController>().furnitureInteractor = null;
            _light.SetActive(false);
        }
    }

    void BeatAnime(KoreographyEvent evt)
    {
        //print("Beat " + BeatCount + " " + BeatLoop[BeatCount]);
        
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
                else
                {
                    rd.material = RestingMat;
                }
            }
            else if (Demonstrating)
            {
                Demonstrating = false;
                if (PlayerInPlace)
                {
                    Checking = true;
                    rd.material = CheckingMat;
                    scoring.SetActive(true);
                }
                else
                {
                    Resting = true;
                    rd.material = RestingMat;
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
                        rd.material = ActivatedMat;                        
                    }
                    else
                    {
                        Demonstrating = true;
                        perfect = 0;
                        miss = 0;
                        perfectText.text = "Perfect: ";
                        missText.text = "Miss: ";
                        rd.material = DemonstratingMat;
                    }
                }
                else
                {
                    Resting = true;
                    rd.material = RestingMat;
                }
            }
        }
        
        //Beat Demonstration
        if (BeatLoop[BeatCount] && (Demonstrating || Activated))
        {
            transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
            _audioSource.Play();

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
