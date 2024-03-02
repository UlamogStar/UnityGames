using UnityEngine;

public class MouseBehavior : MonoBehaviour
{
    public GameAction gameActionObj;

   void onMouseOver()
   {
        gameActionObj.Raise();
   }

   void onMouseExit()
   {
        gameActionObj.Raise();
   }

    void onMouseDown()
    {
          gameActionObj.Raise();
    }

    void onMouseUp()
    {
          gameActionObj.Raise();
    }

}
