using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

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

    [Header("In Game Stat")] 
    public FurnitureInteractor furniture;
    
    private Rigidbody playerRb;
    private Vector3 originalScale;
    private bool beatable;
    private bool alreadybeat;
    private MeshRenderer rd;

    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventIDOpen,BeatReady);
        Koreographer.Instance.RegisterForEvents(EventIDClose,BeatExpire);
        
        playerRb = GetComponent<Rigidbody>();
        originalScale = transform.localScale;
        rd = GetComponent<MeshRenderer>();
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
            if (beatable && !alreadybeat)
            {
               transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
               rd.material = PerfectMat;
               alreadybeat = true;
               if (furniture != null && furniture.Checking)
               {
                   if (furniture.BeatLoop[(furniture.BeatCount + furniture.BeatLoop.Count - 1) % furniture.BeatLoop.Count])
                   {
                       furniture.perfect++;
                       furniture.perfectText.text = "Perfect: " + furniture.perfect;                   
                   }
                   else
                   {
                       furniture.miss++;
                       furniture.missText.text = "Miss: " + furniture.miss;
                       rd.material = MissMat;
                   }
               }
            }
            else
            {
               rd.material = MissMat;
               if (furniture != null && furniture.Checking)
               {
                   furniture.miss++;
                   furniture.missText.text = "Miss: " + furniture.miss;
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
