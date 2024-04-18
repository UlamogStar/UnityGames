using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
public class GameEndBehavior : MonoBehaviour
{
   public UnityEvent gameEndEvent;
   private void OnTriggerEnter(Collider other)
   {
       gameEndEvent.Invoke();
   }

   private void GameEnd()
   {
        Time.timeScale = 0;
      
    }   
}
