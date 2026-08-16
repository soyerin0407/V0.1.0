using UnityEngine;

public class HubStateButton : MonoBehaviour
{
    [SerializeField]
    private HubState targetState;

    public void ChangeState()
    {
        HubStateManager.Instance.ChangeState(targetState);
    }
}