using UnityEngine;
using UnityEngine.Events;

public class IDCompareBehavior : MonoBehaviour
{
    public ID idData;
    public IDDataList idDataList;
    
    public GameAction gameActionObj;

    public UnityEvent compareEvent_1,compareEvent_2,compareEvent_3;

    public void onClickBehavior()
    {
        if (idData == idDataList.idDataList[0])
        {
            compareEvent_1.Invoke();
        }
        else if (idData == idDataList.idDataList[1])
        {
            compareEvent_2.Invoke();
        }
        else if (idData == idDataList.idDataList[2])
        {
            compareEvent_3.Invoke();
        }
    }

        
}



 
    