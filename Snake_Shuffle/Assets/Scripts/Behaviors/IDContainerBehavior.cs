using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
    public ID idObj;

    public IDDataList idDataListObj;
    public UnityEvent startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }   
}