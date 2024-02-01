using UnityEngine;

public class MatchBehavior : MonoBehaviour
{   
   public ID idObj;

   private void OnTriggerEnter(Collider other)
   {  
        var obj = other.GetComponent<IDContainerBehavior>().idObj;
        if(obj != null)
        {
            otherID = obj;
        }
        var tempOBJ = other.GetComponent<IDContainerBehavior>();
         if (tempOBJ != null) otherID = tempOBJ.idObj;
         return;

        var otherID = tempObj.idObj;
    if (idObj == otherID)
     {
         Debug.Log("Match");
     }
   }
}
