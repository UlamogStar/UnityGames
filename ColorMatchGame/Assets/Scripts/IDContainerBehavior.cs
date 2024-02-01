using UnityEngine;

public class IDContainerBehavior : MonoBehaviour
{
    public ID idObj;

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<IDContainerBehavior>().idObj;

        if (idObj == otherID)
        {
            Debug.Log("Match");
        }
        else
        {
            Debug.Log("No Match");
        }
    }
}