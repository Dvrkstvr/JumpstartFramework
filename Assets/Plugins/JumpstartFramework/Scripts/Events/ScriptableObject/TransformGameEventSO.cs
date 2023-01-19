using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/TransformGameEvent")]
public class TransformGameEventSO : ScriptableObject
{
    public event UnityAction<Transform> OnEventRaised;

    public void RaiseEvent(Transform value)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(value);
    }
}