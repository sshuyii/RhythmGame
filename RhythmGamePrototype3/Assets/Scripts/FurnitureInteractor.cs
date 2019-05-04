using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using SonicBloom.Koreo;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;
using UnityEngine.UI;
using cakeslice;

public class FurnitureInteractor : MonoBehaviour
{   
    [Header("Beat Control")]
    public string EventID;
    public List<bool> BeatLoop;
    public int BeatCount;
    public GameObject beatIndicator;
    public int section;
    public int totalBeats;
    
    [Header("Preset")]
    public GameObject spotLight;    
    public int numGroup = 1;
    private MelodyPlay MelodyPlay;
    
    [Header("Animation")]
    //public float ShrinkDepth;
   // public float RecoverRate;
    public GameObject Furniture;
    public GameObject Furniture2;
    public bool readyPunch;
    public GameObject UI;
    private GameObject FullUI;
    private GameObject StrokeUI;
    private CanvasRenderer rdFull;
    private CanvasRenderer rdStroke;
    
    
    private HeartBeating HeartBeating;
    private Image _imageUI;

    private Animator _anim;
    private Animator _animNew;
    private Animator _animUI;
    public int punchUI = 0;
    

    public string FurnitureName;

    
    [Header("In Game Situation")] 
    //public bool PlayerInPlace;
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

    public List<PlayerController> playersInvolved; 

   
    
    //以下是新加的
    //public GameObject _light;
    public AudioSource _audioSource;
    

    [Header("Checking")] 
    //public int perfect;
    //public int miss;
    //public Text perfectText;
    //public Text missText;
    public int requiredPerfect;
    public int requiredCorrectPlayers;
    public int correctPlayers;
    public int requiredPerfectTimes;
    public int localPerfectTimes = 0;
    //public bool beatable = false;

    
    [Header("Functional")]
    public LevelProcessor levelProcessor;
    public Collider _colliderForPlayer;    
    //public GameObject _collider;//设为通用的，在awake function里自行寻找
    
    // Start is called before the first frame update
    private MeshRenderer rd;
    //private Vector3 originalScale;
    private GameObject scoring;    
    
    //找到每个有renderer能描边的物体，为了ui描边做准备
    private cakeslice.Outline[] childOutlines;

    
    
    void Start()
    {
        MelodyPlay = GameObject.Find("/BGM").GetComponent<MelodyPlay>();

        Koreographer.Instance.RegisterForEvents(EventID,BeatAnime);

        levelProcessor = GameObject.Find("GameManager").GetComponent<LevelProcessor>();
       
        childOutlines = GetComponentsInChildren<cakeslice.Outline>();
        //新加
        _audioSource = GetComponent<AudioSource>();
        _anim = Furniture.GetComponent<Animator>();
        _animNew = Furniture2.GetComponent<Animator>();
        //_animUI = UI.GetComponent<Animator>();

        //找到填充的UI
        FullUI = GameObject.Find(FurnitureName + "UI/Full");
        StrokeUI = GameObject.Find(FurnitureName + "UI/Stroke");
        rdStroke = StrokeUI.GetComponent<CanvasRenderer>();
        rdFull = FullUI.GetComponent<CanvasRenderer>();

        rdFull.SetAlpha(0);
        rdStroke.SetAlpha(0);
        

        _imageUI = FullUI.GetComponent<Image>();
        _imageUI.fillAmount = 0;

        spotLight = transform.Find("SpotLight").gameObject;

        //HeartBeating = UI.GetComponent<HeartBeating>();
            
        //originalScale = transform.localScale;
        scoring = transform.Find("Scoring").gameObject;

        foreach (var Beat in BeatLoop)
        {
            if (Beat) requiredPerfect++;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //PlayerInPlace = true;
            
            //将该玩家(的脚本）加入互动中的玩家列表
            PlayerController script = other.GetComponent<PlayerController>();
            script.furnitureInteractor = this;
            playersInvolved.Add(script);
            //_light.SetActive(true);
            print("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            /*if (Resting)
            {
                //rd.material = WaitingMat;                
            }*/

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //PlayerInPlace = false;
            _anim.SetBool("IsMoving", false);
            
            //将该玩家（的脚本）移出互动中玩家列表
            PlayerController script = other.GetComponent<PlayerController>();
            script.furnitureInteractor = null;
            playersInvolved.Remove(script);
            ResetPlayerScore(script);
            
            rdFull.SetAlpha(0);
            rdStroke.SetAlpha(0);

            //_light.SetActive(false);
        }
    }

    void BeatAnime(KoreographyEvent evt)
    {
        if (gameObject.name == "ClockInteractor")
        {
            totalBeats++;
            print("totalBeats " + totalBeats + "-----------------------------------------------------");
            print("beatCount " + BeatCount);
        }
        
        //print("Beat " + BeatCount + " " + BeatLoop[BeatCount]);
        /*if (BeatCount == 1)
        {
            section = 1 - section;
        }*/
        
        if (beatIndicator != null && (Demonstrating || Checking || Activated))
        {
            beatIndicator.transform.localPosition = new Vector3((BeatCount + 7) % BeatLoop.Count, section, beatIndicator.transform.localPosition.z);        
        }
        
        //Status check
        if (BeatCount == 0)
        {
            _animNew.SetTrigger("IsBack");
            _animNew.SetTrigger("IsRepeat");
            
            //针对UI
//            _animUI.SetTrigger("Beat0");
//            _animUI.SetTrigger("Beat1");   


            if (Resting)
            {
                if (playersInvolved.Count > 0)
                {
                    Resting = false;
                    Demonstrating = true;

                    section = 1;

                    _anim.SetBool("IsPlayer", false);
                    outlineEnabled();
                    
                    //if (DoCategorize() == true)
                    //{
                        //打开家具聚光灯并开始动画，并开始UI
                        spotLight.SetActive(true);
                        _anim.SetBool("IsMoving", true);

                        //print(")))))))))))))))))");

                        rdFull.SetAlpha(1);
                        rdStroke.SetAlpha(1);
                    //}
                  //print("is Resting!!!!!!!!" + Demonstrating);
                }
            }
            else if (Demonstrating)
            {
                Demonstrating = false;
                
                //关闭家具聚光灯并停止动画
               
                    _anim.SetBool("IsMoving", false);
                    //if (DoCategorize() == true)
                    //{
                        _anim.SetBool("IsPlayer", true);
                        outlineDisabled();
                    //}
                    spotLight.SetActive(false);

                
               

                if (playersInvolved.Count > 0)
                {
                    Checking = true;                    
                    //scoring.SetActive(true);

                    section = 0;
                    
                    //打开所有互动中玩家聚光灯及分数板
                    foreach (var player in playersInvolved)
                    {
                        player.spotLight.SetActive(true);    
                    }
                    
                    //rd.material = CheckingMat;
                }
                else
                {
                    Resting = true;
                    //rd.material = RestingMat;
                }
            }
            else if (Checking)
            {                
                Checking = false;
                
                if (playersInvolved.Count > 0)
                {
                    //打开家具聚光灯
                    spotLight.SetActive(true);
                    
                    //检测每个玩家的分数并统计打对的玩家个数
                    foreach (var player in playersInvolved)
                    {
                        if (player.localPerfect == requiredPerfect && player.localMiss == 0)
                        {
                            correctPlayers++;//用在每个玩家打一次就对的时候
                            
                            //以下用在打多次才能对的时候
                            //localPerfectTimes++;
                            
                        }
                                               
                        
                        //检测完后重置分数
                        ResetPlayerScore(player);                                              
                    }
                    
                    if (correctPlayers >= requiredCorrectPlayers)
                    {

                        localPerfectTimes++;

                        //更换UI
                        //_animUI.SetTrigger("IsFull");
                    }

                    correctPlayers = 0;                    
                    
                    if(requiredPerfectTimes == 3)
                    {
                        //给动画设置trigger
                        if (localPerfectTimes == 1)
                        {
                            _imageUI.fillAmount = 0.305f;
                        }
                        else if (localPerfectTimes == 2)
                        {
                            _imageUI.fillAmount = 0.7f;
                        }
                        else if (localPerfectTimes == 3)
                        {
                            _imageUI.fillAmount = 1f;
                        }
                    }
                    else if (requiredPerfectTimes == 2)
                    {
                        //给动画设置trigger
                        if (localPerfectTimes == 1)
                        {
                            _imageUI.fillAmount = 0.5f;
                        }
                        else if (localPerfectTimes == 2)
                        {
                            _imageUI.fillAmount = 1f;
                        }
                       
                    }

                    //(单独一个人)有没有达到多次perfect的标准
                    if (localPerfectTimes == requiredPerfectTimes)
                    {
                        //correctPlayers++;
                        //激活
                        Activated = true;
                        if(playersInvolved[0].IsTutorial == false)
                        {
                            MelodyPlay.activatedFurnitureNum++;
                        }                        
                        levelProcessor.FinishCheck();
                        //_anim.SetBool("IsActivated", true);
                        Furniture.SetActive(false);
                        Furniture2.SetActive(true);
                        //rd.material = ActivatedMat;                        
                    }
                    else
                    {
                        /*perfect = 0;
                        miss = 0;
                        perfectText.text = "Perfect: ";
                        missText.text = "Miss: ";*/
                        //rd.material = DemonstratingMat;
                        
                        //回到演示状态
                        Demonstrating = true;
                        _anim.SetBool("IsPlayer", false);
                        outlineEnabled();
                        section = 1;

                        //if (DoCategorize() == true)
                        //{
                            //打开家具聚光灯并开始动画，并开始UI
                        spotLight.SetActive(true);
                        _anim.SetBool("IsMoving", true);


                        rdFull.SetAlpha(1);
                        rdStroke.SetAlpha(1);
                        //    }                    
                    }   

                    

                }
                else
                {
                    Resting = true;
                    //rd.material = RestingMat;
                }
            }
            else if (Activated)
            {
                _anim.SetBool("IsActivated", true);//播放家具动画
            }
        }
        
        
        
        
        //Beat Demonstration
        if (BeatLoop[BeatCount])
        {
            if (Demonstrating || Checking)
            {
                readyPunch = true;   
            }
           
            
            if (Demonstrating || Activated)
            {
                
                //transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
                //Invoke("Recover", RecoverRate);            
                //以上用animation取代
                _audioSource.Play();
                
            } 
        }
        
        
        //To next beat
        BeatCount = (BeatCount + 1) % BeatLoop.Count;


        
        

    }

    /*void Recover()
    {
        transform.localScale = originalScale;
    }*/
    
    // Update is called once per frame
    void ResetPlayerScore(PlayerController player)
    {
        player.localPerfect = 0;
        player.localMiss = 0;
        player.localPerfectText.text = "Perfect:";
        player.localMissText.text = "Miss:";
        player.spotLight.SetActive(false);
    }

    //private bool toZero = false;

    void Update()
    {
        if (DoCategorize() == true)
        {
            _colliderForPlayer.enabled = true;
        }
        else
        {
            _colliderForPlayer.enabled = false;

        }
    }
    /*void Update()
    {
        HeartBeatUI();
    }

    void HeartBeatUI()
    {
        if (BeatLoop[BeatCount] == true)
        {
            
            punchUI++;
         
            //发声的这一拍，传给furnitureInteractor,UI可以开始震动
          
            print("punchUI = " + punchUI);
 
        }
        else
        {
            punchUI = 0;
        }

      

           
        if (punchUI == 1)
        {
            HeartBeating._readyPunch = true;     
        }
        else if (punchUI > 17)
        {
            punchUI = 0;
        }
    }*/
    
    //判断这一组有没有进行完
    

    //判断现在到底进行到了哪一组
    bool DoCategorize()
    {
        bool temp = false;
        
        if(FurnitureName == "Clock"
           || FurnitureName == "Table"
           || FurnitureName == "Bath"
           || FurnitureName == "Box")
        {
            if (numGroup == 1)
            {
//                

                temp = true;
            }
        }
                        
        else if(FurnitureName == "Fridge"
                || FurnitureName == "Bed"
                || FurnitureName == "Swing"
                || FurnitureName == "Extracter"
        )
        {
            if (numGroup == 2)
            {
                //print("fridgeeeeeeeeeeeee");

                temp = true;
//                //打开家具聚光灯并开始动画，并开始UI
//                spotLight.SetActive(true);
//                //rd.material = DemonstratingMat;
//                _anim.SetBool("IsMoving", true);
//                _anim.SetBool("IsPlayer", false);
//                                
//                                 
//                rdFull.SetAlpha(1);
//                rdStroke.SetAlpha(1);

            }
        }

        return temp;

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

}
