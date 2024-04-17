using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class HoverBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hovered");
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Unhovered");
    }
}
