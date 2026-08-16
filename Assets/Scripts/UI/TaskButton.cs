using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TaskButton : MonoBehaviour
{
    [SerializeField] private TMP_Text title;

    private UIWindow targetWindow;

    public void Initialize(UIWindow window)
    {
        targetWindow = window;

        title.text = window.WindowID.ToString();

        GetComponent<Button>()
            .onClick
            .AddListener(OnClickRestore);
    }

    private void OnClickRestore()
    {
        WindowManager.Instance.Restore(targetWindow.WindowID);
    }
}