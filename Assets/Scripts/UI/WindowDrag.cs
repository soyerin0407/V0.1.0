using UnityEngine;
using UnityEngine.EventSystems;

public class WindowDrag : MonoBehaviour,
    IPointerDownHandler,
    IDragHandler
{
    [SerializeField]
    private RectTransform window;

    private Vector2 offset;

    public void OnPointerDown(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            window.parent as RectTransform,
            eventData.position,
            eventData.pressEventCamera,
            out Vector2 localPoint);

        offset = window.anchoredPosition - localPoint;
    }

    public void OnDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            window.parent as RectTransform,
            eventData.position,
            eventData.pressEventCamera,
            out Vector2 localPoint);

        window.anchoredPosition = localPoint + offset;
    }
}