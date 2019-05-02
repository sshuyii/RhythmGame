using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProcessor : MonoBehaviour
{
    public FurnitureInteractor[] furnitureInteractors;
    public GameObject finishCanvas;
    public int activatedFurniture;

    public bool testMode;

    public int beatCount;
    public int windowCount;

    public FurnitureInteractor furniture;
    public PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        if (testMode)
        {
            foreach (var furniture in furnitureInteractors)
            {
                furniture.requiredPerfect = 0;
                furniture.requiredCorrectPlayers = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //beatCount = furniture.BeatCount;
        //windowCount = player.windowCount;
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
        }
        else
        {
            activatedFurniture = 0;
        }
    }
}
