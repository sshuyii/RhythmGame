using System;
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
    public int BeatCount;
    
    [Header("Animation")]
    //public float ShrinkDepth;
   // public float RecoverRate;
    public GameObject Furniture;
    public GameObject Furniture2;

    private Animator _anim;
    private Animator _animNew;

    
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
    public GameObject spotLight;
    public List<PlayerController> playersInvolved;

    //以下是新加的
    //public GameObject _light;
    private AudioSource _audioSource;
    

    [Header("Checking")] 
    //public int perfect;
    //public int miss;
    //public Text perfectText;
    //public Text missText;
    public int requiredPerfect;
    public int requiredCorrectPlayers;
    public int correctPlayers;
    
    private MeshRenderer rd;
    //private Vector3 originalScale;
    private GameObject scoring;
    
    //public GameObject _collider;//设为通用的，在awake function里自行寻找
    
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventID,BeatAnime);

        //rd = Furniture.GetComponent<MeshRenderer>();
       
        //新加
        _audioSource = GetComponent<AudioSource>();
        _anim = Furniture.GetComponent<Animator>();
        _animNew = Furniture2.GetComponent<Animator>();
        spotLight = transform.Find("SpotLight").gameObject;
        
            
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
//            _anim.SetBool("IsPlayer", true);
            
            //将该玩家（的脚本）移出互动中玩家列表
            PlayerController script = other.GetComponent<PlayerController>();
            script.furnitureInteractor = null;
            playersInvolved.Remove(script);
            ResetPlayerScore(script);

            //_light.SetActive(false);
        }
    }

    void BeatAnime(KoreographyEvent evt)
    {
        //print("Beat " + BeatCount + " " + BeatLoop[BeatCount]);
        
        
        
        
        //Status check
        if (BeatCount == 0)
        {
            _animNew.SetTrigger("IsBack");
            _animNew.SetTrigger("IsRepeat");

            if (Resting)
            {
                if (playersInvolved.Count > 0)
                {
                    Resting = false;
                    Demonstrating = true;
                    
                    //打开家具聚光灯并开始动画
                    spotLight.SetActive(true);
                    //rd.material = DemonstratingMat;
                    _anim.SetBool("IsMoving", true);           
                    _anim.SetBool("IsPlayer", false);

                }
                else
                {
                    //rd.material = RestingMat;
                }
            }
            else if (Demonstrating)
            {
                Demonstrating = false;
                
                //关闭家具聚光灯并停止动画
                spotLight.SetActive(false);                
                _anim.SetBool("IsMoving", false);      
                _anim.SetBool("IsPlayer", true);

                if (playersInvolved.Count > 0)
                {
                    Checking = true;                    
                    //scoring.SetActive(true);
                    
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
                            correctPlayers++;
                        }
                        
                        //检测完后重置分数
                        ResetPlayerScore(player);                                              
                    }

                    if (correctPlayers >= requiredCorrectPlayers)
                    {
                        //激活
                        Activated = true;
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
                        _anim.SetBool("IsMoving", true);
                        _anim.SetBool("IsPlayer", false);
                    }

                    correctPlayers = 0;
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
        if (BeatLoop[BeatCount] && (Demonstrating || Activated))
        {
            //transform.localScale -= new Vector3(0, originalScale.y * ShrinkDepth, 0);
            //Invoke("Recover", RecoverRate);            
            //以上用animation取代
            
            _audioSource.Play();
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
    
}
