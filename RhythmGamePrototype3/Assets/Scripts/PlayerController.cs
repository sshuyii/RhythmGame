﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Rewired;
using Rewired.ComponentControls.Effects;
//using UnityEditor.iOS;
using UnityEngine.Analytics;
using Outline = cakeslice.Outline;


//Usage: Control players that uses Unity Input manager.
//Intent: The controller can be used on multiple players.

public class PlayerController : MonoBehaviour
{
    [Header("Player Setting")]
    public float speed = 6;
    //player Id from Rewire
    public int playerId = 0;
    //the rewire player
    protected Player RewirePlayer;
    public bool IsLeft;
    public bool IsTutorial;
    public string Version;
    private SpriteRenderer _ladderRenderer;
    private bool aroundLadder;
    private Sprite arrowUp;
    private Sprite arrowDown;
    private bool startBool;

    private bool temp = false;

    //for tiny analytics
    private int stop = 0;
    private float timer;
    
    [Header("Interaction")]
    public GameObject LadderLeft;
    public GameObject LadderRight;
    private OutlineCalling Outlinecallingleft;
    private OutlineCalling OutlinecallingRight;
    private OutlineCalling _outlineCalling;
    private Sprite ladderSprite;

    public GameObject LadderUI;
    public GameObject nextLevelButton;

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
    public GameObject BabyModel;
    private Animator animBaby;
        
    private int AnimationCount = 0;
    private Collider _myCollider;
    private Transform bodyTran;

    public bool PlayerEnabled = true;//用来判断此时能不能让玩家控制角色
    //public float ShrinkDepth;
    //public float RecoverRate;
    //public Material NormalMat;
    //public Material PerfectMat;
    //public Material MissMat;

    [Header("Koreo")] 
    public string EventIDOpen;
    public string EventIDClose;

    [Header("UI")] 
    //public GameObject spotLight;
    

    [Header("In Game Stat")] 
    public FurnitureInteractor furnitureInteractor;
    public int localPerfect;
    public int localMiss;
    //public Text localPerfectText;
    //public Text localMissText;
    public int windowCount;

    //[Header("Narrative")] 
    //public NarrativeControl dialogManager;
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
    
    private cakeslice.Outline[] childOutlines;

    private Sprite up;
    private Sprite down;

    void Awake()
    {
        //用于梯子sprite替换
        if(IsTutorial == false)
        {
            _ladderRenderer = LadderUI.GetComponent<SpriteRenderer>();

            Texture2D ladderUp = (Texture2D) Resources.Load("LadderUp"); //更换为红色主题英雄角色图片
            up = Sprite.Create(ladderUp, _ladderRenderer.sprite.textureRect, new Vector2(0.5f, 0.5f)); //注意居中显示采用0.5f值

            Texture2D ladderDown = (Texture2D) Resources.Load("LadderDown"); //更换为红色主题英雄角色图片
            down = Sprite.Create(ladderDown, _ladderRenderer.sprite.textureRect,
                new Vector2(0.5f, 0.5f)); //注意居中显示采用0.5f值


            Tinylytics.AnalyticsManager.LogCustomMetric("GameStart", "0");
        }

            
            
        childOutlines = GetComponentsInChildren<cakeslice.Outline>();

        if(IsTutorial == false)

        {
            Outlinecallingleft = LadderLeft.GetComponent<OutlineCalling>();
            OutlinecallingRight = LadderRight.GetComponent<OutlineCalling>();
        }

        
        
        //Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        RewirePlayer = ReInput.players.GetPlayer(playerId);
        animBaby = BabyModel.GetComponent<Animator>();
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

        Register();
       
    }

    public void Register()
    {
        Koreographer.Instance.RegisterForEvents(EventIDOpen,BeatReady);
        //Koreographer.Instance.RegisterForEvents(EventIDClose,BeatExpire);
        //Koreographer.Instance.RegisterForEvents("AllBeats", Rebeatable);
        //imageUI = UI.GetComponent<Image>();        
    }

    public void Unregister()
    {
        Koreographer.Instance.UnregisterForEvents(EventIDOpen,BeatReady);
    }

    /*void Rebeatable(KoreographyEvent evt)
    {
        alreadybeat = false;
    }*/
    void BeatReady(KoreographyEvent evt)
    {
        //print("reset");
        //if(gameObject.name == "Player1")
        //print("windowCount " + windowCount);
        //beatable = true;
        //furnitureInteractor.beatable = true;
        alreadybeat = false;

        if (furnitureInteractor != null)
        {
            windowCount = furnitureInteractor.BeatCount;
        }
        else
        {
            windowCount = (windowCount + 1) % 8;
        }
        

    }

    /*void BeatExpire(KoreographyEvent evt)
    {
        beatable = true;
        //furnitureInteractor.beatable = false;

    }*/

    private void _animating(float h, float v)
    {
        // Create a boolean that is true if either of the input axes is non-zero.
        bool walking = h != 0f || v != 0f;

        // Tell the animator whether or not the player is walking.
        anim.SetBool ("IsWalking", walking);
        if(IsTutorial)
        {
            animBaby.SetBool("IsWalking", walking);
        }
    }


    private float _rotate;
    private float _rotation;
    
    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        
        if (IsTutorial && furnitureInteractor != null && furnitureInteractor.Activated)
        {
            if (furnitureInteractor.BeatCount == 1)
            {
                anim.SetBool("BabyToRight2",false);
                anim.SetBool("BabyToLeft1",true);
            }
            else if (furnitureInteractor.BeatCount == 3)
            {
                anim.SetBool("BabyToLeft2",true);
                anim.SetBool("BabyToLeft1",false);

            }
            else if (furnitureInteractor.BeatCount == 5)
            {
                anim.SetBool("BabyToRight1",true);
                anim.SetBool("BabyToLeft2",false);

            }
            else if (furnitureInteractor.BeatCount == 7)
            {
                anim.SetBool("BabyToRight1",false);

                anim.SetBool("BabyToRight2",true);
            }
          
            
        }

        
        if (furnitureInteractor != null && furnitureInteractor.Activated)
        {
           outlineDisabled();

           if(stop == 0)

           {
               string _myAnalyticTime =
                   furnitureInteractor.FurnitureName + " + " + "Player" + playerId.ToString() + " + " +
                   timer.ToString();
               //以下用于games & players的ab test，判断打完一个家具之后到底用了多长时间
               Tinylytics.AnalyticsManager.LogCustomMetric("FurnitureFinished", _myAnalyticTime);
               stop = 1;
           }
        
           
            
        }
        
        if(IsTutorial == false)
        {
            LadderControl();
        }

        if (!PlayerEnabled)
        {
            return;
        }
        else
        {
            temp = false;
        }
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
//        print("player is moving =" + movement);


        // Move the player

        playerRb.MovePosition (transform.position + movement);
            
        if (!(x == 0 && z == 0))
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }
        
        
        _animating(x, z);
        
        //imageUI.sprite = Chopping;

        if (furnitureInteractor != null)
        { 
            if (furnitureInteractor.Checking)
            {
                outlineEnabled();
            }
            else if (furnitureInteractor.Demonstrating)
            {
                
                outlineDisabled();
            }

        }
        else if(aroundLadder == false)
        {
            outlineDisabled();
        }
       
        //Interaction
        if (RewirePlayer.GetButtonDown("Interact"))
        {
            //用于Narrative的Interact
            if (NarrativeControl.narrativeControl != null && NarrativeControl.narrativeControl.expectingInteraction && (NarrativeControl.narrativeControl.currentInteractingPlayer == playerId || NarrativeControl.narrativeControl.currentInteractingPlayer == 3))
            {
                print("Next");
                NarrativeControl.narrativeControl.interactionDetected = true;
            }

            if (nextLevelButton.activeSelf)
            {
                nextLevelButton.GetComponent<NextLevelButton>().Restart();
            }
            
            if(furnitureInteractor != null)
            {
                if(Version == "A")
                {
                    bool rightTime;
                    if (furnitureInteractor.Demonstrating == true)
                    {
                        rightTime = false;
                    }
                    else
                    {
                        rightTime = true;}
                    
//                    string _myAnalytic =
//                        furnitureInteractor.FurnitureName + " + " + "Player" + playerId.ToString() + " + " +
//                        furnitureInteractor.BeatCount.ToString() + "+" + rightTime.ToString();
//                    Tinylytics.AnalyticsManager.LogCustomMetric("VersionA + FurnitureName + Id + Hit",
//                        _myAnalytic);


                    if (startBool == false)
                    {
                        Tinylytics.AnalyticsManager.LogCustomMetric(furnitureInteractor.FurnitureName.ToString() + " Start",
                            timer.ToString());
                        startBool = true;
                    }

                    string _myAnalytic =
                        furnitureInteractor.FurnitureName + " + " + "Player" + playerId.ToString() + " + " +
                        furnitureInteractor.BeatCount.ToString() + "+" + rightTime.ToString();
                    
                    Tinylytics.AnalyticsManager.LogCustomMetric(furnitureInteractor.FurnitureName.ToString() + playerId.ToString(),
                        rightTime.ToString());
                }
                
                else if(Version == "B")
                {
                    string _myAnalytic =
                        furnitureInteractor.FurnitureName + " + " + "Player" + playerId.ToString() + " + " +
                        furnitureInteractor.BeatCount.ToString();
//                    Tinylytics.AnalyticsManager.LogCustomMetric("VersionB + FurnitureName + Id + Hit",
//                        _myAnalytic);
                }
               
                
            }
           
            
            if (/*beatable && */!alreadybeat)
            {
               //print(windowCount);
               //transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
               //rd.material = PerfectMat;
               alreadybeat = true;

               if (furnitureInteractor != null && furnitureInteractor.Checking)
               {
                   //print(windowCount);
                   
                   if (furnitureInteractor.BeatLoop[windowCount])
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
        
        /*if (!beatable && alreadybeat)
        {
            alreadybeat = false;
        }*/
        
        //第零拍的时候重设AnimationCount
        if (furnitureInteractor != null && furnitureInteractor.BeatCount == 1)
        {
            if (IsTutorial == false)
            {
                AnimationCount = 0;

            }
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
        //localPerfectText.text = "Perfect: " + localPerfect;
        Instantiate(perfectParticle, transform.position + 3 * Vector3.up, Quaternion.identity);
        perfectParticle.SetActive(true);
        //_audioSource[2].Play();
        if (furnitureInteractor.FurnitureName == "Piano")
        {
            if (windowCount == 1)
            {
                furnitureInteractor._myAudioList[0].Play();
            }
            else if (windowCount == 2)
            {
                furnitureInteractor._myAudioList[1].Play();
                //print("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!audio!");
            }
            else if (windowCount == 3)
            {
                furnitureInteractor._myAudioList[2].Play();
            }
            else if (windowCount == 4)
            {
                furnitureInteractor._myAudioList[3].Play();
            }
            else if (windowCount == 6)
            {
                furnitureInteractor._myAudioList[4].Play();
            }
            else if (windowCount == 7)
            {
                furnitureInteractor._myAudioList[5].Play();
            }
        }
        else
        {
            furnitureInteractor._audioSource.Play();
        }        
        AnimationCount += 1;

        if(IsTutorial == false)
        {
            if (AnimationCount == 1)
            {
                anim.SetBool("Dancing1", true);
                anim.SetBool("Failed", false);


                //print("Dancing11111111");
            }
            else if (AnimationCount == 2)
            {
                anim.SetBool("Dancing1", false);
                anim.SetBool("Dancing2", true);
                anim.SetBool("Failed", false);


                //print("Dancing222222");

            }
            else if (AnimationCount == 3)
            {
                anim.SetBool("Dancing2", false);
                anim.SetBool("Dancing1", false);
                anim.SetBool("Dancing3", true);
                anim.SetBool("Failed", false);


            }
            else if (AnimationCount == 4)
            {
                anim.SetBool("Dancing2", false);
                anim.SetBool("Dancing1", false);
                anim.SetBool("Dancing3", false);
                anim.SetBool("Dancing4", true);
                anim.SetBool("Failed", false);

            }
        }
        else if (IsTutorial == true)
        {
            
            if (AnimationCount % 4 == 1)
            {
                anim.SetBool("BabyToRight2",false);
                anim.SetBool("BabyToRight1", false);
                anim.SetBool("BabyToLeft1", true);
                
                anim.SetBool("Failed", false);
                
                animBaby.SetBool("BabyToRight2",false);
                animBaby.SetBool("BabyToRight1", false);
                animBaby.SetBool("BabyToLeft1", true);
                
                animBaby.SetBool("Failed", false);
                

            }
            else if (AnimationCount % 4 == 2)
            {
                anim.SetBool("BabyToRight2",false);
                anim.SetBool("BabyToRight1", false);
                anim.SetBool("BabyToLeft1", false);

                anim.SetBool("BabyToLeft2", true);
                
                animBaby.SetBool("BabyToRight2",false);
                animBaby.SetBool("BabyToRight1", false);
                animBaby.SetBool("BabyToLeft1", false);
                animBaby.SetBool("BabyToLeft2", true);


                animBaby.SetBool("BabyToLeft2", true);
              
            }
            else if (AnimationCount % 4 == 3)
            {
                anim.SetBool("BabyToRight2",false);
                anim.SetBool("BabyToLeft1", false);
                anim.SetBool("BabyToLeft2", false);
                
                animBaby.SetBool("BabyToRight2",false);
                animBaby.SetBool("BabyToLeft1", false);
                animBaby.SetBool("BabyToLeft2", false);
                
                animBaby.SetBool("BabyToRight1", true);


                anim.SetBool("BabyToRight1", true);
                

            }
            else if (AnimationCount % 4 == 0)
            {
                anim.SetBool("BabyToLeft1", false);
                anim.SetBool("BabyToLeft2", false);
                anim.SetBool("BabyToRight1", false);
                
                
                animBaby.SetBool("BabyToLeft1", false);
                animBaby.SetBool("BabyToLeft2", false);
                animBaby.SetBool("BabyToRight1", false);
                
                animBaby.SetBool("BabyToRight2", true);

                anim.SetBool("BabyToRight2", true);
                anim.SetBool("Failed", false);
              
            }
        }
       

        
    }

    void Miss()
    {
       localMiss++;
       //localMissText.text = "Miss: " + localMiss;
       Instantiate(errorParticle, transform.position + 3 * Vector3.up, Quaternion.identity);
       _audioSource[1].Play();
       if (IsTutorial == false)
       {
           anim.SetBool("Failed",true);

       }

    }

    //判断到底是左边的梯子还是右边的梯子

    private float UpperAngle;
    private float BottomAngle;

    void LadderControl()
    {

        RaycastHit hit;
        Debug.DrawRay(transform.position + Vector3.up, transform.forward * 2f, Color.yellow);


        if (IsLeft == true)
        {
            BottomLocator = LeftBottomLocator;
            UpperLocator = LeftUpperLocator;
            BottomAngle = 45;
            UpperAngle = 45;
            _outlineCalling = Outlinecallingleft;
        }
        else
        {
            BottomLocator = RightBottomLocator;
            UpperLocator = RightUpperLocator;
            BottomAngle = -45;
            UpperAngle = -45;
            _outlineCalling = OutlinecallingRight;

        }


        if (Physics.Raycast(transform.position + Vector3.up, transform.forward * 2f, out hit, 2f))
        {

            if (hit.collider.CompareTag("DownStairs"))
            {

                aroundLadder = true;
                _ladderRenderer.sprite = up;
                //为了避免collider直接被teleport到目标位置
                if (temp == false)
                {
                    LadderUI.SetActive(true);
                    temp = true;
                    outlineEnabled();
                }

                //_outlineCalling.playerOnLadder = true;
                PlayerOnLadder();

                if (RewirePlayer.GetButtonDown("Interact"))
                {
                    transform.position = BottomLocator.transform.position;
                    transform.rotation = Quaternion.AngleAxis(BottomAngle, Vector3.up);
                    _myCollider.isTrigger = true;
                    //anim.SetTrigger("Reset");
                    anim.SetBool("Jump", true);
                    PlayerEnabled = false;
                    LadderUI.SetActive(false);
                }

            }
            else if (hit.collider.CompareTag("UpStairs"))
            {
                aroundLadder = true;
                _ladderRenderer.sprite = down;

                
                //为了避免collider直接被teleport到目标位置
                if (temp == false)
                {
                    LadderUI.SetActive(true);
                    temp = true;
                    outlineEnabled();
                }         
                
                //_outlineCalling.playerOnLadder = true;
                outlineEnabled();

                PlayerOnLadder();

                if (RewirePlayer.GetButtonDown("Interact"))
                {
                    transform.position = UpperLocator.transform.position;
                    //print("hittttttLadder");
                    transform.rotation = Quaternion.AngleAxis(UpperAngle, Vector3.up);
                    _myCollider.isTrigger = true;
                    //anim.SetTrigger("Reset");
                    anim.SetBool("Fall", true);

                    PlayerEnabled = false;
                    LadderUI.SetActive(false);
                }
            }
            else
            {
                LadderUI.SetActive(false);
                aroundLadder = false;
                //PlayerEnabled = true;

                _outlineCalling.player1 = false;
                _outlineCalling.player2 = false;
                _outlineCalling.player3 = false;
            
            }
        }
        else
        {
            LadderUI.SetActive(false);
            //PlayerEnabled = true;

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

                outlineEnabled();
                PlayerOnLadder();


                anim.SetBool("Jump", false);
                PlayerEnabled = true;

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
                    outlineEnabled();
                    PlayerOnLadder();

                    anim.SetBool("Fall", false);
                    PlayerEnabled = true;

                }

            }
       
    }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("LeftOrRight"))
            {
                IsLeft = false;
                //(print"IsRight");
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("LeftOrRight"))
            {
                IsLeft = true;
                //print("IsLeft");

            }
        }

        void outlineEnabled()
        {
            foreach (cakeslice.Outline c in childOutlines)
            {
                c.Enabling();
            }
        }

        void outlineDisabled()
        {
            foreach (cakeslice.Outline c in childOutlines)
            {
                c.Disabling();
            }
        }

        void PlayerOnLadder()
        {
            if (playerId == 0)
            {
                _outlineCalling.player1 = true;
                _outlineCalling.player2 = false;
                _outlineCalling.player3 = false;
                
            }
            else if (playerId == 1)
            {
                _outlineCalling.player2 = true;
                _outlineCalling.player1 = false;
                _outlineCalling.player3 = false;
            }
            else if (playerId == 2)
            {
                _outlineCalling.player3 = true;
                _outlineCalling.player1 = false;
                _outlineCalling.player2 = false;
            }
        }
    

}
