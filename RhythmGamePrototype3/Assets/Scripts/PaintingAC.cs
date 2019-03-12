using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingAC : MonoBehaviour
{
   private Animator anim;
   public AnimatingController AnimatingController;

   private void Awake()
   {
      anim = GetComponent <Animator> ();

   }

   private void Update()
   {
      if (AnimatingController._activate)
      {
         anim.SetBool ("IsRotating", true);
      }
      else if (!AnimatingController._activate)
      {
         anim.SetBool ("IsRotating", false);
      }
   }

  
}

