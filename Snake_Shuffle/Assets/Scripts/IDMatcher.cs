using UnityEngine;
using UnityEngine.Events;

public class IDMatcher : MonoBehaviour
{
    public IDDataList idDataList; // Reference to your IDDataList ScriptableObject
    public UnityEvent drawEvent, matchEvent, lossEvent;

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
        ID idObj = idValue; // Use the idValue field directly

        if (idObj == null || otherID == null)
        {
            Debug.LogWarning("IDs are null.");
            return;
        }

        if (idObj == otherID)
        {
            Draw();
        }
        else if ((idObj.idValue == 1 && otherID.idValue == 3) || // Rock > Scissors
                 (idObj.idValue == 2 && otherID.idValue == 1) || // Paper > Rock
                 (idObj.idValue == 3 && otherID.idValue == 2))   // Scissors > Paper
        {
            Match();
        }
        else
        {
            Loss();
        }
    }

    private void Draw()
    {
        Debug.Log("Draw: Same IDs.");
        drawEvent.Invoke();
    }

    private void Match()
    {
        Debug.Log("Match: Opposite IDs.");
        matchEvent.Invoke();
    }

    private void Loss()
    {
        Debug.Log("Loss: Not opposite but not equal IDs.");
        lossEvent.Invoke();
    }
}
