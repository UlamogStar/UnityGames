using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu]

public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    private int num;
    
    public void SetColorIDRandom()
    {
        num = Random.Range(0, colorIDList.Count - 1);
        currentColor = colorIDList[num];
    }

    public void SetColorID()
    {
        currentColor = colorIDList[num];
    }

}
