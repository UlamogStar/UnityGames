using UnityEngine;

public class GameEndBehavior : MonoBehaviour
{   
    private int IntData;

   public void gameEndBehavior(IntData obj)
   {
         if (obj.value < 0)
         {
             Debug.Log("Game Over");
             Time.timeScale = 0f; 
         }
   }
}
