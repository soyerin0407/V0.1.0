using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public static WindowManager Instance { get; private set; }

    private Dictionary<WindowID, UIWindow> windows = new();

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void Register(UIWindow window)
    {
        if (!windows.ContainsKey(window.WindowID))
        {
            windows.Add(window.WindowID, window);
        }
    }

    public void Open(WindowID id)
    {
        if (!windows.TryGetValue(id, out UIWindow window))
            return;

        window.Open();
        Focus(window);
    }

    public void Close(WindowID id)
    {
        if (!windows.TryGetValue(id, out UIWindow window))
            return;

        window.Close();
    }

    public void Minimize(WindowID id)
    {
        if (!windows.TryGetValue(id, out UIWindow window))
            return;

        window.SetMinimized();

        if (TaskBarManager.Instance != null)
        {
            TaskBarManager.Instance.AddButton(window);
        }
    }

    public void Focus(UIWindow window)
    {
        window.transform.SetAsLastSibling();
    }

    public void Restore(WindowID id)
    {
        if (!windows.TryGetValue(id, out UIWindow window))
            return;

        window.Open();
        Focus(window);

        if (TaskBarManager.Instance != null)
        {
            TaskBarManager.Instance.RemoveButton(id);
        }
    }
}
