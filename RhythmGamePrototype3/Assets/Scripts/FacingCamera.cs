using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    private Vector3 CameraLookDirection;
    public GameObject player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        CameraLookDirection = Camera.main.transform.forward;

        
        //让UI面向镜头
//        Full.transform.LookAt(Camera.main.transform.position);	
//        Stroke.transform.LookAt(Camera.main.transform.position);	

        Quaternion rotation = Quaternion.LookRotation(CameraLookDirection, Vector3.up);

        transform.rotation = rotation;
        transform.position = player.transform.position + offset;
    }
}
