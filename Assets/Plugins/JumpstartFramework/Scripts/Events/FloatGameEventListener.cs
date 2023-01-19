using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class FloatEvent : UnityEvent<float>
{ }

public class FloatGameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    [SerializeField] private FloatGameEventSO _eventChannel = default;

    [Tooltip("Response to invoke when Event is raised.")]
    public FloatEvent OnEventRaised;

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

    public void Respond(float value)
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
    }
}