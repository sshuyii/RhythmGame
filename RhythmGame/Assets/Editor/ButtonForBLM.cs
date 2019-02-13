using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BeatLevelManager))]
public class ButtonForBLM : Editor
{
   public override void OnInspectorGUI()
   {
      BeatLevelManager _myBeatLevelManager = (BeatLevelManager) target;
      DrawDefaultInspector();

      if (GUILayout.Button("Add new beat"))
      {
         Debug.Log("Button pressed.");
         //Vector2 newBeat = _myBeatLevelManager.targetObject.gameObject.AddComponent<Vector2>();
         
         _myBeatLevelManager.beatList.Add(_myBeatLevelManager.Beat);
      } 
      
   }
}
