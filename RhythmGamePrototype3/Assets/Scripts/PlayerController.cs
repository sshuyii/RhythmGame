using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using UnityEngine.Serialization;

//Usage: Control players that uses Unity Input manager.
//Intent: The controller can be used on multiple players.

public class PlayerController : MonoBehaviour
{
    [Header("Player Setting")]
    public float speed = 6;
    public int playerNum;
    public KeyCode interaction;
    
    [Header("Animation")]
    public float ShrinkDepth;
    public float RecoverRate;
    public Material NormalMat;
    public Material PerfectMat;
    public Material MissMat;

    [Header("Koreo")] 
    public string EventIDOpen;
    public string EventIDClose;

    [FormerlySerializedAs("furniture")] [Header("In Game Stat")] 
    public FurnitureInteractor furnitureInteractor;
    //public GameObject furniture;//后加的,但是现在player发出的声音是一样的
    
    
    private Rigidbody playerRb;
    private Vector3 originalScale;
    private bool beatable;
    private bool alreadybeat;
    private MeshRenderer rd;
    private AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventIDOpen,BeatReady);
        Koreographer.Instance.RegisterForEvents(EventIDClose,BeatExpire);
        
        playerRb = GetComponent<Rigidbody>();
        originalScale = transform.localScale;
        rd = GetComponent<MeshRenderer>();
        _audioSource = GetComponent<AudioSource>();
    }

    void BeatReady(KoreographyEvent evt)
    {
        beatable = true;
    }

    void BeatExpire(KoreographyEvent evt)
    {
        beatable = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Reset Interaction signal
        
        transform.rotation = new Quaternion (0,  0, 0, 0);
        
        //Movement
        float x = Input.GetAxisRaw("Horizontal" + playerNum) * speed;
        float z = Input.GetAxisRaw("Vertical" + playerNum) * speed;
        playerRb.velocity = new Vector3(x, 0, -z);
        
        //Interaction
        if (Input.GetKeyDown(interaction))
        {
            _audioSource.Play();//后加的

            if (beatable && !alreadybeat)
            {
               transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
               rd.material = PerfectMat;
               alreadybeat = true;

               
               if (furnitureInteractor != null && furnitureInteractor.Checking)
               {
                   if (furnitureInteractor.BeatLoop[(furnitureInteractor.BeatCount + furnitureInteractor.BeatLoop.Count - 1) % furnitureInteractor.BeatLoop.Count])
                   {
                       furnitureInteractor.perfect++;
                       furnitureInteractor.perfectText.text = "Perfect: " + furnitureInteractor.perfect;
                   }
                   else
                   {
                       furnitureInteractor.miss++;
                       furnitureInteractor.missText.text = "Miss: " + furnitureInteractor.miss;
                       rd.material = MissMat;
                   }
               }
            }
            else
            {
               rd.material = MissMat;
               if (furnitureInteractor != null && furnitureInteractor.Checking)
               {
                   furnitureInteractor.miss++;
                   furnitureInteractor.missText.text = "Miss: " + furnitureInteractor.miss;
               }
            }
            Invoke("Recover", RecoverRate);    
        }
        
        if (!beatable && alreadybeat)
        {
            alreadybeat = false;
        }                 
    }
    
    void Recover()
    {
        transform.localScale = originalScale;
        rd.material = NormalMat;
    }    
}
