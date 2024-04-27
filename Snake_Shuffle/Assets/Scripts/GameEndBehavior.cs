using UnityEngine;
using UnityEngine.Events;

public class GameEndBehavior : MonoBehaviour
{
    public UnityEvent gameEndEvent;
    public IntData intData; // Reference to your IntData ScriptableObject
    public int minValue; // Minimum value to trigger the event

    public void OnTriggerEnter(Collider other)
    {
        if (intData != null && intData.value == minValue)
        {
            gameEndEvent.Invoke();
            gameEnd();
        }
    }

    public void gameEnd()
    {
        Time.timeScale = 0;
        Debug.Log("Game Over");
    }
}
