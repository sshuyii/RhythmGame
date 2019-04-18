using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Rewired;

//Usage: Control players that uses Unity Input manager.
//Intent: The controller can be used on multiple players.

public class PlayerController : MonoBehaviour
{
    [Header("Player Setting")]
    public float speed = 6;
    //player Id from Rewire
    public int playerId = 0;
    //the rewire player
    private Player RewirePlayer;
    public bool IsLeft;

    public GameObject LadderUI;
    //public KeyCode interaction;

    [Header("Animation")] 
    public GameObject perfectParticle;
    public GameObject errorParticle;

    private GameObject BottomLocator;
    private GameObject UpperLocator;
    
    public GameObject LeftBottomLocator;
    public GameObject LeftUpperLocator;
    public GameObject RightBottomLocator;
    public GameObject RightUpperLocator;
    
        
    private int AnimationCount = 0;
    private Collider _myCollider;
    private Transform bodyTran;

    private bool PlayerEnabled = true;//用来判断此时能不能让玩家控制角色
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
    

    [Header("In Game Stat")] 
    public FurnitureInteractor furnitureInteractor;
    public int localPerfect;
    public int localMiss;
    public Text localPerfectText;
    public Text localMissText;
    //public GameObject furniture;//后加的,但是现在player发出的声音是一样的
    
    
    private Rigidbody playerRb;
    private Vector3 originalScale;
    private bool beatable;
    private bool alreadybeat;
    private MeshRenderer rd;
    private AudioSource[] _audioSource;
    //private Image imageUI;
    
    // Reference to the animator component
    private Animator anim;                     
    private Vector3 movement;
    
    float smooth = 45.0f;
    float tiltAngle = 90.0f;
    Quaternion target;


    void Awake()
    {
        //Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        RewirePlayer = ReInput.players.GetPlayer(playerId);
        // Set up references.
        anim = GetComponent <Animator> ();
        _myCollider = GetComponent<Collider>();
        bodyTran = this.gameObject.transform.GetChild(0);
        
        playerRb = GetComponent<Rigidbody>();
        originalScale = transform.localScale;
        rd = GetComponent<MeshRenderer>();
        _audioSource = GetComponents<AudioSource>();
        //spotLight = transform.Find("SpotLight").gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventIDOpen,BeatReady);
        Koreographer.Instance.RegisterForEvents(EventIDClose,BeatExpire);
        //imageUI = UI.GetComponent<Image>();
        
       
    }

    void BeatReady(KoreographyEvent evt)
    {
        beatable = true;
        //furnitureInteractor.beatable = true;

    }

    void BeatExpire(KoreographyEvent evt)
    {
        beatable = false;
        //furnitureInteractor.beatable = false;

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
       
        LadderControl();
        //Reset Interaction signal
        //transform.Rotate(0, _rotate, 0,Space.World);
        //Vector3 target = new Vector3(0, _rotation, 0);

        //transform.rotation = target;
        
        //transform.rotation = new Quaternion (0,  0, 0, 0);
        
        //Movement
        float x = RewirePlayer.GetAxisRaw("Move Horizontal") * speed;
        float z = RewirePlayer.GetAxisRaw("Move Vertical") * speed;
        //float x = Input.GetAxisRaw("Horizontal" + playerNum) * speed;
        //float z = Input.GetAxisRaw("Vertical" + playerNum) * speed;
        //playerRb.velocity = new Vector3(x, 0, -z);
        
        // Set the movement vector based on the axis input.
        movement.Set (x, 0f, z);
        
        // Normalise the movement vector and make it proportional to speed per second.
        movement = movement.normalized * speed * Time.deltaTime;
        //print("player is moving =" + movement);


        // Move the player
        if (PlayerEnabled == true)
        {
            playerRb.MovePosition (transform.position + movement);
            
            if (!(x == 0 && z == 0))
            {
                transform.rotation = Quaternion.LookRotation(movement);
            }
        }
        
        
      

        //控制player的朝向
        // Smoothly tilts a transform towards a target rotation.
//        float tiltAroundZ = Input.GetAxis("Horizontal" + playerNum) * tiltAngle;
//        float tiltAroundX = Input.GetAxis("Vertical" + playerNum) * tiltAngle;
//        print("x=" + x);
//        print("z=" + z);
        
        // if(x > 0)
        // {
        //     /*transform.Rotate(0, 45, 0,Space.World);
        //     _rotation = transform.rotation.y;*/
            
        //     transform.localEulerAngles = new Vector3(0,45,0);


        // }
        // else if (x < 0)
        // {
        //     /*transform.Rotate(0, -125, 0,Space.World);
        //     _rotation = transform.rotation.y;*/
            
        //     transform.localEulerAngles = new Vector3(0,-135,0);

        // }
        
        // if(z > 0)
        // { 
        //     /*transform.Rotate(0, -45, 0,Space.World);
        //     _rotation = transform.rotation.y;*/
            
        //     transform.localEulerAngles = new Vector3(0, -45, 0);

           
        // }
        // else if (z < 0)
        // {
        //     /*transform.Rotate(0, 125, 0,Space.World);
        //     _rotation = transform.rotation.y;*/
            
        //     transform.localEulerAngles = new Vector3(0, 135, 0);

        // }
        
        
       

        // Dampen towards the target rotation
        //transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);

        
        
        _animating(x, z);
        
        //imageUI.sprite = Chopping;

        //Interaction
        if (RewirePlayer.GetButtonDown("Interact"))
        {            
            if (beatable && !alreadybeat)
            {
               //transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
               //rd.material = PerfectMat;
               alreadybeat = true;

               if (furnitureInteractor != null && furnitureInteractor.Checking)
               {
                   if (furnitureInteractor.BeatLoop[(furnitureInteractor.BeatCount + furnitureInteractor.BeatLoop.Count - 1) % furnitureInteractor.BeatLoop.Count])
                   {
                       Perfect();                   
                   }
                   else
                   {
                       Miss();
                   }
               }
               else
               {
                   _audioSource[0].Play();
               }
            }
            else
            {
               if (furnitureInteractor != null && furnitureInteractor.Checking)
               {
                  Miss();
               }
            }   
        }
        
        if (!beatable && alreadybeat)
        {
            alreadybeat = false;
        }
        
        //第零拍的时候重设AnimationCount
        if (furnitureInteractor != null && furnitureInteractor.BeatCount == 1)
        {
            AnimationCount = 0;
            anim.SetBool("Dancing1", false);
            anim.SetBool("Dancing3", false);
            anim.SetBool("Failed",false);
            anim.SetBool("Dancing2", false);
            anim.SetBool("Dancing4", false);

        }
    }

    void Perfect()
    {
        localPerfect++;
        localPerfectText.text = "Perfect: " + localPerfect;
        Instantiate(perfectParticle, transform.position + Vector3.up, Quaternion.identity);
        _audioSource[2].Play();
        
        AnimationCount += 1;

        if (AnimationCount == 1)
        {
            anim.SetBool("Dancing1", true);
            anim.SetBool("Failed",false);

           
            print("Dancing11111111");
        }
        else if (AnimationCount == 2)
        {
            anim.SetBool("Dancing1", false);
            anim.SetBool("Dancing2", true);
            anim.SetBool("Failed",false);


            print("Dancing222222");

        }
        else if (AnimationCount == 3)
        {
            anim.SetBool("Dancing2", false);
            anim.SetBool("Dancing1", false);
            anim.SetBool("Dancing3",true);
            anim.SetBool("Failed",false);

            
        }
        else if (AnimationCount == 4)
        {
            anim.SetBool("Dancing2", false);
            anim.SetBool("Dancing1", false);
            anim.SetBool("Dancing3",false);
            anim.SetBool("Dancing4",true);  
            anim.SetBool("Failed",false);

        }
       

        
    }

    void Miss()
    {
       localMiss++;
       localMissText.text = "Miss: " + localMiss;
       Instantiate(errorParticle, transform.position + 2 * Vector3.up, Quaternion.identity);
       _audioSource[1].Play();       
       anim.SetBool("Failed",true);

    }

    //判断到底是左边的梯子还是右边的梯子

    private float UpperAngle;
    private float BottomAngle;
    
    void LadderControl()
    {

        RaycastHit hit;
        Debug.DrawRay(transform.position + Vector3.up, transform.forward * 4f, Color.yellow);


        if (IsLeft == true)
        {
            BottomLocator = LeftBottomLocator;
            UpperLocator = LeftUpperLocator;
            BottomAngle = 45;
            UpperAngle = 45;
        }
        else
        {
            BottomLocator = RightBottomLocator;
            UpperLocator = RightUpperLocator;
            BottomAngle = -45;
            UpperAngle = -45;
        }
        
        
        if (Physics.Raycast(transform.position + Vector3.up, transform.forward * 4f, out hit, 4f))
        {
            
           
            if (hit.collider.CompareTag("DownStairs"))
            {
                LadderUI.SetActive(true);

                if (RewirePlayer.GetButtonDown("Interact"))
                {
                    transform.position = BottomLocator.transform.position;
                    transform.rotation = Quaternion.AngleAxis(BottomAngle, Vector3.up);
                    _myCollider.isTrigger = true;
                    anim.SetBool("Jump",true);
                    
                    PlayerEnabled = false;
                    LadderUI.SetActive(false);
                }
                
            }
            else if(hit.collider.CompareTag("UpStairs"))
            {
                LadderUI.SetActive(true);

                if (RewirePlayer.GetButtonDown("Interact"))
                {
                    transform.position = UpperLocator.transform.position;
                    //print("hittttttLadder");
                    transform.rotation = Quaternion.AngleAxis(UpperAngle, Vector3.up);
                    _myCollider.isTrigger = true;
                    anim.SetBool("Fall",true);
                    
                    PlayerEnabled = false;
                    LadderUI.SetActive(false);
                }   
            }
        }
        else
        {
            LadderUI.SetActive(false);

        }
        
        AnimatorStateInfo stateinfo = anim.GetCurrentAnimatorStateInfo(0);
        //transform.position = _myAnim.rootPosition;


        if (stateinfo.IsName("Jump") && (stateinfo.normalizedTime > 1.0f))
        {
            _myCollider.isTrigger = false;
            if (anim.GetBool("Jump"))
            {
                transform.position = UpperLocator.transform.position;
                _myCollider.transform.position = UpperLocator.transform.position;

                PlayerEnabled = true;
                anim.SetBool("Jump",false);
            }
               
        }
        else if (stateinfo.IsName("Fall") && (stateinfo.normalizedTime > 1.0f))
        {
            _myCollider.isTrigger = false;
            if (anim.GetBool("Fall"))
            {
                transform.position = BottomLocator.transform.position;
                _myCollider.transform.position = BottomLocator.transform.position;

                PlayerEnabled = true;
                anim.SetBool("Fall",false);
            }
               
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LeftOrRight"))
        {
            IsLeft = !IsLeft;
            print("!!!!!!!!!!");

        }
    }
}
