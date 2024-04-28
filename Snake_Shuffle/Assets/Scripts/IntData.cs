using UnityEngine;

[CreateAssetMenu(fileName = "IntData", menuName = "ScriptableObjects/IntData", order = 2)]
public class IntData : ScriptableObject
{
    public int value;

    public IntData IntDataObj;

    public void SetValue(IntData obj)
    {
        value = obj.value;
    }

    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntData obj)
    {
        if (value >= obj.value)
        {
            return;
        }
        else
        {
            value = obj.value;
        }
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}
