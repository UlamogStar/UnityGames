using System.Collections.Generic;
using UnityEngine;

public class IntDataList : ScriptableObject
{
    public List<IntData> DataList;

    public void UpdateValue(int IntDataObj)
    {
        foreach (var intData in DataList)
        {
            intData.UpdateValue(IntDataObj);
        }
    }

}
