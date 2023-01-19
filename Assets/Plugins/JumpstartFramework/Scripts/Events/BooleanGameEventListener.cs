using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class BoolEvent : UnityEvent<bool>
{ }

public class BooleanGameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    [SerializeField] private BooleanGameEventSO _eventChannel = default;

    [Tooltip("Response to invoke when Event is raised.")]
    public BoolEvent OnEventRaised;

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

    public void Respond(bool value)
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
    }
}