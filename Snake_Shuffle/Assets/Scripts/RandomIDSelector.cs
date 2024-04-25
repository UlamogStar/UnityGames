using UnityEngine;

public class RandomIDSelector : MonoBehaviour
{
    public IDDataList idDataList; 

    public void Start()
    {
        SelectRandomID();
    }

    void SelectRandomID()
    {
        if (idDataList != null && idDataList.idDataList.Count > 0)
        {
            int randomIndex = Random.Range(0, idDataList.idDataList.Count);
            ID selectedID = idDataList.idDataList[randomIndex];
            Debug.Log("Selected ID: " + selectedID);
        }
        else
        {
            Debug.LogWarning("IDDataList is empty or not assigned.");
        }
    }
}
