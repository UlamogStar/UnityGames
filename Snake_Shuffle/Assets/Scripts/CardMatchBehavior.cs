
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CardMatchBehavior : MonoBehaviour
{   public ID idObj;
    public IDDataList idDataListObj;

    public UnityEvent searchEvent;

    public UnityEvent matchEvent;

    public void OnButtonClick(Button button)
    {
        searchEvent.Invoke();
    }

   private void onClickBehavior()
   {
    var tempOBJ = GetComponent<IDContainerBehavior>();
         if (tempOBJ == null) 
              return; 

         var otherID = tempOBJ.idObj;
         if(otherID == idObj)
            {
                Debug.Log("Match");
                matchEvent.Invoke();
            }
        else
            {
                Debug.Log("No Match");
            }

   }
}

