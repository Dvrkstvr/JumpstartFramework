using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class IntEvent : UnityEvent<int>
{ }

public class IntGameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    [SerializeField] private IntGameEventSO _eventChannel = default;

    [Tooltip("Response to invoke when Event is raised.")]
    public IntEvent OnEventRaised;

    private void OnEnable()
    {
        if (_eventChannel != null)
        {
            _eventChannel.OnEventRaised += Respond;
        }
    }

    private void OnDisable()
    {
        if (_eventChannel != null)
        {
            _eventChannel.OnEventRaised -= Respond;
        }
    }

    public void Respond(int value)
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
    }
}
