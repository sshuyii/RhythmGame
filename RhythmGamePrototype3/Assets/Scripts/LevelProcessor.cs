using System.Collections;
using System.Collections.Generic;
using SonicBloom.Koreo;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProcessor : MonoBehaviour
{
    public FurnitureInteractor[] furnitureInteractors;
    public PlayerController[] players;
    public AudioSource[] BGM;
    public GameObject finishCanvas;
    public int activatedFurniture;



    

    
    
    [Header("Debugger")]
    public bool testMode;
    public int beatCount;
    public int windowCount;
    
    [Header("CrossFade")]
    public float crossfadingTime;
    public AnimationCurve fadingCurveUp;

    public AnimationCurve fadingCurveDown;
    //public FurnitureInteractor furniture;
    //public PlayerController player;
    private MelodyPlay _melodyPlay;

    private List<AudioSource> _furnitureSF = new List<AudioSource>();

    private List<float> oriVolume = new List<float>();
    // Start is called before the first frame update
    private void Awake()
    {
        _melodyPlay = GetComponent<MelodyPlay>();
        foreach (var furniture in furnitureInteractors)
        {
            if (testMode)
            {
                furniture.requiredPerfect = 0;
                furniture.requiredCorrectPlayers = 0;
            }

            AudioSource audioTemp = furniture.GetComponent<AudioSource>();
            _furnitureSF.Add(audioTemp);
            oriVolume.Add(audioTemp.volume);
        }        
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //beatCount = furnitureInteractors[0].BeatCount;
        //windowCount = players[0].windowCount;

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ChangeBGM()
    {
        Unregister();
        BGM[_melodyPlay.groupNum - 1].gameObject.SetActive(true);
        ChangeEventID();
        Register();
        StartCoroutine(CrossFading());
        StartCoroutine(TuningDown());
        print("BGM Changed");
    }
    
    void Unregister()
    {
        foreach (var furniture in furnitureInteractors)
        {
            furniture.Unregister();
        }

        foreach (var player in players)
        {
            player.Unregister();
        }
        print("Unregister");
    }

    void ChangeEventID()
    {
        foreach (var furniture in furnitureInteractors)
        {
            furniture.EventID = furniture.EventID.Substring(0, furniture.EventID.Length - 1) + _melodyPlay.groupNum;
        }
        
        foreach (var player in players)
        {
            player.EventIDOpen = player.EventIDOpen.Substring(0, player.EventIDOpen.Length - 1) + _melodyPlay.groupNum;
        }
        
        print("EventID Changed");        
    }

    IEnumerator CrossFading()
    {
        float timer = 0;

        while (timer < crossfadingTime)
        {
            BGM[_melodyPlay.groupNum - 2].volume = Mathf.Lerp(1, 0, fadingCurveDown.Evaluate(timer / crossfadingTime));
            BGM[_melodyPlay.groupNum - 1].volume = Mathf.Lerp(0, 1, fadingCurveUp.Evaluate(timer / crossfadingTime));

            yield return 0;

            timer++;
        }
        
        BGM[_melodyPlay.groupNum - 2].gameObject.SetActive(false);
        
        print("Crossfaded");
    }

    IEnumerator TuningDown()
    {
        float timer = 0;

        while (timer < 120f)
        {
            for (int i = 0; i < furnitureInteractors.Length; i++)
            {
                if (furnitureInteractors[i].numGroup == _melodyPlay.groupNum - 1)
                {
                    _furnitureSF[i].volume = Mathf.Lerp(oriVolume[i], 0.2f * oriVolume[i], timer / 120f);
                }
            }

            yield return 0;

            timer++;
        }
        
        print("tuned");
    }

    void Register()
    {
        foreach (var furniture in furnitureInteractors)
        {
            furniture.Register();
        }

        foreach (var player in players)
        {
            player.Register();
        }
        
        print("Registered");
    }

    public void FinishCheck()
    {
        foreach (var furniture in furnitureInteractors)
        {
            if (furniture.Activated)
            {
                activatedFurniture++;
            }
        }

        if (activatedFurniture == furnitureInteractors.Length)
        {
            finishCanvas.SetActive(true);
            NarrativeControl.narrativeControl.NextStep();
        }
        else
        {
            activatedFurniture = 0;
        }
    }
}
