using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D rb;
   public Text scoreText;
   public event Action onDeath;
   private void Start()
   {
      rb = GetComponent<Rigidbody2D>();
   }

   private void Update()
   {
      if (Input.GetMouseButtonDown(0) && !GameManager.Instance.Dead)
      {
         rb.velocity = Vector2.up * 4;
      }
   }

   private void OnCollisionEnter2D(Collision2D other)
   {
      rb.velocity = Vector2.zero;
      onDeath?.Invoke();
   }

   private void OnTriggerExit2D(Collider2D other)
   {
      GameManager.Instance.Score++;
   }
}
