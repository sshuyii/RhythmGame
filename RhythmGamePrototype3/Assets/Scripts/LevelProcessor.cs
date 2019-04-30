using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProcessor : MonoBehaviour
{
    public FurnitureInteractor[] furnitureInteractors;
    public GameObject finishCanvas;
    public int activatedFurniture;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
