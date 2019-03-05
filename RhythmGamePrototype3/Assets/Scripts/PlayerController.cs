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
    
    [Header("Anime")]
    public float ShrinkDepth;
    public float RecoverRate;
    public Material Normal;
    public Material Perfect;
    public Material Miss;

    [Header("Koreo")] 
    public string EventIDOpen;
    public string EventIDClose;
    
    private Rigidbody playerRb;
    private Vector3 originalScale;
    private bool beatable;
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
        transform.rotation = new Quaternion (0,  0, 0, 0);

        float x = Input.GetAxisRaw("Horizontal" + playerNum) * speed;
        float z = Input.GetAxisRaw("Vertical" + playerNum) * speed;
        playerRb.velocity = new Vector3(x, 0, -z);

        if (Input.GetKeyDown(interaction))
        {
            if (beatable)
            {
               transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
               rd.material = Perfect;
            }
            else
            {
               rd.material = Miss;
            }
            
            Invoke("Recover", RecoverRate); 
        }    
    }
    
    void Recover()
    {
        transform.localScale = originalScale;
        rd.material = Normal;
    }    
}
