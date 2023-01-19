using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [Tooltip("Event to register with.")]
    [SerializeField] private GameEventSO _eventChannel = default;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent OnEventRaised;

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

    public void Respond()
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke();
        }
    }
}
