using UnityEngine;
using UnityEngine.Events;

public class IDMatcher : MonoBehaviour
{
    public IDDataList idDataList; // Reference to your IDDataList ScriptableObject
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;

    public ID idValue;

    public void MatchRandomID()
    {
        if (idDataList == null || idDataList.idDataList.Count == 0)
        {
            Debug.LogWarning("IDDataList is empty or not assigned.");
            return;
        }

        int randomIndex = Random.Range(0, idDataList.idDataList.Count);
        ID selectedID = idDataList.idDataList[randomIndex];

        MatchIDs(selectedID);
    }

    public void MatchIDs(ID otherID)
    {
        ID idObj = GetComponent<IDContainerBehavior>().idObj;

        if (idObj == null || otherID == null)
        {
            Debug.LogWarning("IDs are null.");
            return;
        }

        if (idObj == otherID)
        {
            Debug.Log("Draw: Same IDs.");
            noMatchEvent.Invoke();
        }
        else if ((idObj.idValue == 1 && otherID.idValue == 3) || // Rock > Scissors
                 (idObj.idValue == 2 && otherID.idValue == 1) || // Paper > Rock
                 (idObj.idValue == 3 && otherID.idValue == 2))   // Scissors > Paper
        {
            Debug.Log("Victory: Opposite IDs.");
            matchEvent.Invoke();
        }
        else
        {
            Debug.Log("Loss: Not opposite but not equal IDs.");
            noMatchDelayedEvent.Invoke();
        }
    }
}
