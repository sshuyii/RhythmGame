using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAdvancing : MonoBehaviour
{

    public List<GameObject> rooms;
    public static bool advancing;
    public int roomIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (advancing)
        {
            advancing = false;
            roomIndex++;
            rooms[roomIndex].SetActive(true);
        }
    }
}
