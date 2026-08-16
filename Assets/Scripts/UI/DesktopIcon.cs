using UnityEngine;

public class DesktopIcon : MonoBehaviour
{
    [SerializeField]
    private WindowID targetWindow;

    public void OpenWindow()
    {
        WindowManager.Instance.Open(targetWindow);
    }
}