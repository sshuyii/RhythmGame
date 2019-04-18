using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;
using TMPro;


public class DoLadders : MonoBehaviour
{
    
    public GameObject BottomLocator;
    public GameObject UpperLocator;

    private Collider _myCollider;
    private Transform bodyTran;
    
    private Animator _myAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        //RewirePlayer = ReInput.players.GetPlayer(playerId);
        _myAnim = GetComponent<Animator>();
        _myCollider = GetComponent<Collider>();
        bodyTran = this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _myAnim.rootPosition;

        RaycastHit hit;
        Debug.DrawRay(transform.position, bodyTran.forward * 2f, Color.yellow);

        if (Physics.Raycast(transform.position, bodyTran.forward * 2f, out hit, 1f))
        {
            
            if (hit.collider.CompareTag("DownStairs"))
            {
                
                print("hittttttLadder");
                _myCollider.isTrigger = true;
                _myAnim.SetBool("Jump",true);
            }
        }
        
        AnimatorStateInfo stateinfo = _myAnim.GetCurrentAnimatorStateInfo(0);
        print("rootPosition = " + _myAnim.rootPosition);
        //transform.position = _myAnim.rootPosition;


        if (stateinfo.IsName("Jump") && (stateinfo.normalizedTime > 1.0f))
        {
            if (_myAnim.GetBool("Jump"))
            {
                transform.position = UpperLocator.transform.position;
                _myCollider.transform.position = UpperLocator.transform.position;

                _myAnim.SetBool("Jump",false);
            }
               
        }

    }

    
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
