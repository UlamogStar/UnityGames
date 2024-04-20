using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RandomIDselectBehavior : MonoBehaviour
{
  
    
    public UnityEvent startEvent;
    public UnityEvent randomIDEvent;
    public UnityEvent endEvent;
    public List<ID> idDataList;
 
    
    public int randomID;
    public void Start()
    {
        startEvent.Invoke();
    }
    public void RandomID()
    {
        randomID = Random.Range(0, idDataList.Count);
        randomIDEvent.Invoke();
    }
    public void End()
    {
        endEvent.Invoke();
    }

}



