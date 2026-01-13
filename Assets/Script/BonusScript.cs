using System;
using System.Collections;
using UnityEngine;

public class BonusScript : MonoBehaviour
{ 
   private void OnCollisionEnter2D(Collision2D obj)
   {
      if (obj.gameObject.CompareTag("Cone"))
      {
         Debug.Log("NABRAK CONE");
      }
      if (obj.gameObject.CompareTag("Box"))
      {
         Debug.Log("NABRAK BOX");
      }
   }

   private void OnTriggerEnter2D(Collider2D obj)
   {
      if (obj.gameObject.CompareTag("Bonus"))
      {
         Debug.Log("NABRAK BONUS");
         Destroy(obj.gameObject);
         FindObjectOfType<SpawnManagers>().BonusTaken();
      }
   }
}
