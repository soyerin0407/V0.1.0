using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(UIWindow))]
public class WindowFocusHandler : MonoBehaviour, IPointerDownHandler
{
    private UIWindow window;

    private void Awake()
    {
        window = GetComponent<UIWindow>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        window.Focus();
    }
}