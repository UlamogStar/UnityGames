using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MoveDraggableBehavior : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private bool isDragging = false;
    private Vector3 offset;

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(eventData.position);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(eventData.position) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }

}

