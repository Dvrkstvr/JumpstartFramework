using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/FloatGameEvent")]
public class FloatGameEventSO : ScriptableObject
{
    public event UnityAction<float> OnEventRaised;

    public void RaiseEvent(float value)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(value);
    }
}