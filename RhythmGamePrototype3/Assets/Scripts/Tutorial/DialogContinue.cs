using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class DialogContinue : MonoBehaviour
{
    public int playerId;
    private Player RewiredPlayer;
    public NarrativeControl dialogManager;

    // Start is called before the first frame update
    void Start()
    {
        RewiredPlayer = ReInput.players.GetPlayer(playerId);
    }

    // Update is called once per frame
    void Update()
    {
        if (RewiredPlayer.GetButtonDown("Interact") /*&& dialogManager.currentInteractingPlayer == playerId*/)
        {
            print("Next");
            dialogManager.interactionDetected = true;
        }
    }
}
