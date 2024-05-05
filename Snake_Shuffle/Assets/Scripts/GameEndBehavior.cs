using UnityEngine;
using UnityEngine.Events;

public class GameEndBehavior : MonoBehaviour
{   
    public GameAction gameEndAction;
    public UnityEvent gameEndEvent;
    public IntData intData; // Reference to your IntData ScriptableObject
    private int minValue = -5; // Minimum value to trigger the event

    public void OnTriggerEnter(Collider other)
    {
        if (intData != null && intData.value <= minValue)
        {
            gameEndEvent.Invoke();
            gameEnd();
        }
    }

    public void gameEnd()
    {
        Time.timeScale = 0;
        Debug.Log("Game Over");
        gameEndAction.Raise();
    }
}
