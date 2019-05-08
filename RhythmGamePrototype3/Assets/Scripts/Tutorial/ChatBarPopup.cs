using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatBarPopup : MonoBehaviour
{
    public AnimationCurve popUp;

    public float popUpTime;

    public int currentInteractingPlayer = 2;

    public bool interactionDetected;

    public GameObject chatBoard;

    public List<Text> commands;

    public int step;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform command in chatBoard.transform.Find("DialogCanvas").transform)
        {
            if (command.name.Contains("Command"))
            {
                commands.Add(command.GetComponent<Text>());
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (interactionDetected)
        {
            interactionDetected = false;
            currentInteractingPlayer = 4;
            commands[step].gameObject.SetActive(false);
            commands[step + 1].gameObject.SetActive(true);
            step++;
            //print("Next");
        }
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
