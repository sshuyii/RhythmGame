using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
         
         //_myBeatLevelManager.beatList.Add(_myBeatLevelManager.Beat);
         
         //以下为新增
         List<Vector3> list = _myBeatLevelManager.beatList;
         list.Add(_myBeatLevelManager.Beat);
         int max = list.Count - 1;
         //Debug.Log(max);
         Vector3 x = new Vector3();
         
         
         for (int i = 0; i < max; i++)
         {
            if (list[max - i].y < list[max - i - 1].y)
            {
               x = list[max - i];
               list[max - i] = list[max - i - 1];
               list[max - i - 1] = x;
            }
            else
            {
               Debug.Log("New Beat Inserted as: Element " + (max-i));
               break;
            }
            
            _myBeatLevelManager.beatList = list;
         }
      } 
      
   }
}
