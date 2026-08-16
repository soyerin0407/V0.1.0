using DG.Tweening;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    [SerializeField]
    private WindowID windowID;

    private WindowState state = WindowState.Closed;

    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;

    public WindowState State => state;

    public WindowID WindowID => windowID;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        WindowManager.Instance.Register(this);
    }

    public void Open()
    {
        state = WindowState.Open;

        gameObject.SetActive(true);

        rectTransform.localScale = Vector3.one * 0.95f;
        canvasGroup.alpha = 0f;

        Sequence seq = DOTween.Sequence();

        seq.Join(canvasGroup.DOFade(1f, 0.2f));
        seq.Join(rectTransform.DOScale(1f, 0.2f));
    }

    public void Close()
    {
        state = WindowState.Closed;

        canvasGroup.DOFade(0f, 0.15f)
            .OnComplete(() =>
            {
                gameObject.SetActive(false);
            });
    }

    public void Minimize()
    {
        WindowManager.Instance.Minimize(windowID);
    }

    public void SetMinimized()
    {
        state = WindowState.Minimized;
        gameObject.SetActive(false);
    }

    public void Focus()
    {
        WindowManager.Instance.Focus(this);
    }
}