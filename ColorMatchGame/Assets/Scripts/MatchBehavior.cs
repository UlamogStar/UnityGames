using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
   public ID idObj;
   public ID otherID;

   private void OnTriggerEnter(Collider other)
   {  
        var obj = other.GetComponent<IDContainerBehavior>().idObj;
        if(obj != null)
        {
           
         var tempOBJ = other.GetComponent<IDContainerBehavior>();
         if (tempOBJ != null) otherID = tempOBJ.idObj;
          return;

            if (idObj == otherID)
            {
             Debug.Log("Match");
            }
        }
    }
}