using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;
using UnityEngine.UI;

//Usage: Control players that uses Unity Input manager.
//Intent: The controller can be used on multiple players.

public class PlayerController : MonoBehaviour
{
    [Header("Player Setting")]
    public float speed = 6;
    public int playerNum;
    public KeyCode interaction;
    public GameObject UI;
    
    [Header("Animation")]
    //public float ShrinkDepth;
    //public float RecoverRate;
    //public Material NormalMat;
    //public Material PerfectMat;
    //public Material MissMat;

    [Header("Koreo")] 
    public string EventIDOpen;
    public string EventIDClose;

    [Header("UI")] 
    public Sprite Chopping;
    public Sprite ChoppingWrong;
    public Sprite ChoppingRight;
    public GameObject spotLight;
    

    [FormerlySerializedAs("furniture")] [Header("In Game Stat")] 
    public FurnitureInteractor furnitureInteractor;
    //public GameObject furniture;//后加的,但是现在player发出的声音是一样的
    
    
    private Rigidbody playerRb;
    private Vector3 originalScale;
    private bool beatable;
    private bool alreadybeat;
    private MeshRenderer rd;
    private AudioSource _audioSource;
    private Image imageUI;
    
    // Reference to the animator component
    private Animator anim;                     
    private Vector3 movement;
    
    float smooth = 45.0f;
    float tiltAngle = 90.0f;
    Quaternion target;


    void Awake()
    {
        // Set up references.
        anim = GetComponent <Animator> ();
        
        playerRb = GetComponent<Rigidbody>();
        originalScale = transform.localScale;
        rd = GetComponent<MeshRenderer>();
        _audioSource = GetComponent<AudioSource>();
        spotLight = transform.Find("SpotLight").gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventIDOpen,BeatReady);
        Koreographer.Instance.RegisterForEvents(EventIDClose,BeatExpire);
        imageUI = UI.GetComponent<Image>();
        
       
    }

    void BeatReady(KoreographyEvent evt)
    {
        beatable = true;
    }

    void BeatExpire(KoreographyEvent evt)
    {
        beatable = false;
    }

    private void _animating(float h, float v)
    {
        // Create a boolean that is true if either of the input axes is non-zero.
        bool walking = h != 0f || v != 0f;

        // Tell the animator whether or not the player is walking.
        anim.SetBool ("IsWalking", walking);
    }


    private float _rotate;
    private float _rotation;
    
    // Update is called once per frame
    void Update()
    {
        //Reset Interaction signal
        //transform.Rotate(0, _rotate, 0,Space.World);
        //Vector3 target = new Vector3(0, _rotation, 0);

        //transform.rotation = target;
        
        //transform.rotation = new Quaternion (0,  0, 0, 0);
        
        //Movement
        float x = Input.GetAxisRaw("Horizontal" + playerNum) * speed;
        float z = Input.GetAxisRaw("Vertical" + playerNum) * speed;
        //playerRb.velocity = new Vector3(x, 0, -z);
        
        // Set the movement vector based on the axis input.
        movement.Set (x, 0f, z);
        
        // Normalise the movement vector and make it proportional to the speed per second.
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the player to it's current position plus the movement.
        playerRb.MovePosition (transform.position + movement);

        //控制player的朝向
        // Smoothly tilts a transform towards a target rotation.
//        float tiltAroundZ = Input.GetAxis("Horizontal" + playerNum) * tiltAngle;
//        float tiltAroundX = Input.GetAxis("Vertical" + playerNum) * tiltAngle;
  
        
        if(x > 0)
        {
            /*transform.Rotate(0, 45, 0,Space.World);
            _rotation = transform.rotation.y;*/
            
            transform.localEulerAngles = new Vector3(0,45,0);


        }
        else if (x < 0)
        {
            /*transform.Rotate(0, -125, 0,Space.World);
            _rotation = transform.rotation.y;*/
            
            transform.localEulerAngles = new Vector3(0,-135,0);

        }
        
        if(z > 0)
        { 
            /*transform.Rotate(0, -45, 0,Space.World);
            _rotation = transform.rotation.y;*/
            
            transform.localEulerAngles = new Vector3(0, -45, 0);

           
        }
        else if (z < 0)
        {
            /*transform.Rotate(0, 125, 0,Space.World);
            _rotation = transform.rotation.y;*/
            
            transform.localEulerAngles = new Vector3(0, 135, 0);

        }
       

        // Dampen towards the target rotation
        //transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

        
        
        _animating(x, z);
        
        //imageUI.sprite = Chopping;

        //Interaction
        if (Input.GetKeyDown(interaction))
        {
            

            if (beatable && !alreadybeat)
            {
               //transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
               //rd.material = PerfectMat;
               alreadybeat = true;
               _audioSource.Play();//后加的
               
               if (furnitureInteractor != null && furnitureInteractor.Checking)
               {
                   if (furnitureInteractor.BeatLoop[(furnitureInteractor.BeatCount + furnitureInteractor.BeatLoop.Count - 1) % furnitureInteractor.BeatLoop.Count])
                   {
                       furnitureInteractor.perfect++;
                       furnitureInteractor.perfectText.text = "Perfect: " + furnitureInteractor.perfect;
                       imageUI.sprite = ChoppingRight;
                   }
                   else
                   {
                       furnitureInteractor.miss++;
                       furnitureInteractor.missText.text = "Miss: " + furnitureInteractor.miss;
                       //rd.material = MissMat;
                       imageUI.sprite = ChoppingWrong;
                   }
               }
            }
            else
            {
               //rd.material = MissMat;
               if (furnitureInteractor != null && furnitureInteractor.Checking)
               {
                   furnitureInteractor.miss++;
                   furnitureInteractor.missText.text = "Miss: " + furnitureInteractor.miss;
                   imageUI.sprite = ChoppingWrong;

               }
            }
            //Invoke("Recover", RecoverRate);    
        }
        
        if (!beatable && alreadybeat)
        {
            alreadybeat = false;
        }
    }
    
    /*void Recover()
    {
        transform.localScale = originalScale;
        //rd.material = NormalMat;
    }*/    
}
