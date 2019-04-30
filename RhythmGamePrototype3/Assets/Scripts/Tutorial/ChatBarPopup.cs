using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatBarPopup : MonoBehaviour
{
    public AnimationCurve popUp;

    public float popUpTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ChatBoardPopUp()
    {
        float timer = 0;

        while (timer < popUpTime)
        {
            timer += Time.deltaTime;
            //clock.transform.position = Vector3.LerpUnclamped(clockStartPos, clockEndPos, clockFallCurve.Evaluate(timer / fallTime));
            yield return 0;
        }
    }
}
