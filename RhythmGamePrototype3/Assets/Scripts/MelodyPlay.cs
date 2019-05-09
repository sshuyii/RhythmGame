using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MelodyPlay : MonoBehaviour
{
    public int activatedFurnitureNum = 0;
    public int groupNum;
    
    private float timer = 0;
    private float realTimer = 0;
    public Text TotalTime;
    private bool final;
    private int minute;
    private int second;
    private bool doubleCheck;
    
    private GameObject finalScore;
   //private GameObject finalScoreText;
    private GameObject finalScoreNumber;
    private Image finalScoreImage;
    //private Text _finalScoreText;
    private Text _finalScoreNumber;
    private GameObject star1;
    private GameObject star2;
    private GameObject star3;
   
    private Image star1Image;
    private Image star2Image;
    private Image star3Image;

    private float minScore = 320;
    private float maxScore = 800;

    private LevelProcessor _processor;

    private void Awake()
    {
        _processor = GetComponent<LevelProcessor>();
    }

    // Start is called before the first frame update
    void Start()
    {
        finalScore = GameObject.Find("/FrameRate/FinalScore");
        //finalScoreText = GameObject.Find("/FrameRate/FinalScoreText");
        finalScoreNumber = GameObject.Find("/FrameRate/FinalScoreNumber");
        star1 = GameObject.Find("/FrameRate/Star1");
        star2 = GameObject.Find("/FrameRate/Star2");
        star3 = GameObject.Find("/FrameRate/Star3");




        
        finalScoreImage = finalScore.GetComponent<Image>();
        //_finalScoreText = finalScoreText.GetComponent<Text>();
        _finalScoreNumber = finalScoreNumber.GetComponent<Text>();
        star1Image = star1.GetComponent<Image>();
        star2Image = star2.GetComponent<Image>();
        star3Image = star3.GetComponent<Image>();



    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (groupNum == 1 && activatedFurnitureNum == 4)
        {
            //以下用于games & players的ab test，判断打完第一组家具之后到底用了多长时间
            
            Tinylytics.AnalyticsManager.LogCustomMetric("TimeInTotal1",
                    timer.ToString());
            activatedFurnitureNum = 0;
            groupNum++;
            
            _processor.ChangeBGM();
            
        }
        else if (groupNum == 2 && activatedFurnitureNum == 4)
        {
            //以下用于games & players的ab test，判断打完第一组家具之后到底用了多长时间
            
            Tinylytics.AnalyticsManager.LogCustomMetric("TimeInTotal2",
                timer.ToString());
            activatedFurnitureNum = 0;
            groupNum++;
            
            _processor.ChangeBGM();
        }
        else if (groupNum == 3 && activatedFurnitureNum == 3)
        {
            //以下用于games & players的ab test，判断打完第一组家具之后到底用了多长时间
            
            Tinylytics.AnalyticsManager.LogCustomMetric("TimeInTotal2",
                timer.ToString());
            activatedFurnitureNum = 0;
            groupNum++;
            
            //_processor.ChangeBGM();
        }
        else if(groupNum == 4 && activatedFurnitureNum == 1)
        {
            realTimer += Time.deltaTime;
            if (realTimer > 3f)
            {
                finalScoreImage.enabled = true;
                //_finalScoreText.enabled = true;
                _finalScoreNumber.enabled = true;
                
                doubleCheck = true;
            }
            
            if (final == false && doubleCheck == true)
            {
                minute = (Mathf.FloorToInt(timer) - Mathf.FloorToInt(timer) % 60)/60;
                second = Mathf.FloorToInt(timer) % 60;
                TotalTime.text = minute.ToString() + ":" + second.ToString();
                final = true;

                if (timer < minScore)
                {
                    star1Image.enabled = true;
                    star2Image.enabled = true;
                    star3Image.enabled = true;
                }
                else if (minScore < timer && maxScore > timer)
                {
                    star1Image.enabled = true;
                    star2Image.enabled = true;
                }
                else if (timer > maxScore)
                {
                    star1Image.enabled = true;
                }
            }
                          
            }
            
        }
    }

