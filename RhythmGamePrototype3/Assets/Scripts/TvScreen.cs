using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvScreen : MonoBehaviour
{
    public FurnitureInteractor FurnitureInteractor;

    public Material _tvScreenMat;
    public Material _BlackMat;

    private Renderer _myRenderer;
    public Material _mySecondMaterial;
    
    private Material[] mats;

    
    // Start is called before the first frame update
    void Start()
    {
        _myRenderer = GetComponent<Renderer>();
        _mySecondMaterial = _myRenderer.materials[1];
        mats = _myRenderer.materials;

    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (FurnitureInteractor.Activated == true)
        {
            if (FurnitureInteractor.BeatLoop[FurnitureInteractor.BeatCount] == true)
            {

                _mySecondMaterial = _tvScreenMat;
                mats[1] = _mySecondMaterial;
                _myRenderer.materials = mats;
                
            }
            else
            {
                _mySecondMaterial = _BlackMat;
                mats[1] = _mySecondMaterial;
                _myRenderer.materials = mats;
            }
        }
    }
}
