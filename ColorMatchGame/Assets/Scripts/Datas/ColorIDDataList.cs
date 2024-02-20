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
        currentColor = colorIDList[Random.Range(0, num)];
    }
}
