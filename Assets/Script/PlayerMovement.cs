using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;
   private void Start()
   {
    
      rb = GetComponent<Rigidbody2D>();
   }

   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         rb.velocity = Vector2.up * 4;
      }
   }
}
