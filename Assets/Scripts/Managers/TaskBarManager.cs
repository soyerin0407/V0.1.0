using System.Collections.Generic;
using UnityEngine;

public class TaskBarManager : MonoBehaviour
{
    public static TaskBarManager Instance;

    [SerializeField] private Transform container;
    [SerializeField] private TaskButton taskButtonPrefab;

    private Dictionary<WindowID, TaskButton> buttons = new();

    private void Awake()
    {
        Instance = this;
    }

    public void AddButton(UIWindow window)
    {
        if (buttons.ContainsKey(window.WindowID))
            return;

        TaskButton button =
            Instantiate(taskButtonPrefab, container);

        button.Initialize(window);

        buttons.Add(window.WindowID, button);
    }

    public void RemoveButton(WindowID id)
    {
        if (!buttons.TryGetValue(id, out TaskButton button))
            return;

        Destroy(button.gameObject);

        buttons.Remove(id);
    }
}