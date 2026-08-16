using UnityEngine;

public class HubStateManager : MonoBehaviour
{
    public static HubStateManager Instance;

    [Header("State Roots")]
    [SerializeField] private GameObject officeRoot;
    [SerializeField] private GameObject counselingRoot;
    [SerializeField] private GameObject newPCRoot;
    [SerializeField] private GameObject oldPCRoot;

    public HubState CurrentState { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        ChangeState(HubState.Office);
    }

    public void ChangeState(HubState state)
    {
        officeRoot.SetActive(false);
        counselingRoot.SetActive(false);
        newPCRoot.SetActive(false);
        oldPCRoot.SetActive(false);

        switch (state)
        {
            case HubState.Office:
                officeRoot.SetActive(true);
                break;

            case HubState.Counseling:
                counselingRoot.SetActive(true);
                break;

            case HubState.NewPC:
                newPCRoot.SetActive(true);
                break;

            case HubState.OldPC:
                oldPCRoot.SetActive(true);
                break;
        }

        CurrentState = state;
    }
}