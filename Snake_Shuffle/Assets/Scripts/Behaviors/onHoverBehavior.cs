using UnityEngine;

public class onHoverBehavior : MonoBehaviour
{
    public GameAction gameActionObj;

   void onMouseOver()
   {
        gameActionObj.Raise();
   }

}
