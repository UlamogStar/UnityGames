using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class RandomizeID : MonoBehaviour
{
    public IDDataList idObj;
    public IDDataList[] idArray;
    public bool randomizeID;

   public GameAction randomize;

   public void Randomize()
    {
         idObj = idArray[Random.Range(0, idArray.Length)];
    }
    private void Start()
    {
        if (randomizeID)
        {
            idObj = idArray[Random.Range(0, idArray.Length)];
        }
    }

}
