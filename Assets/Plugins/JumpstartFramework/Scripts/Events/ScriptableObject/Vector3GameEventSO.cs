using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Vector3GameEvent")]
public class Vector3GameEventSO : ScriptableObject
{
    public event UnityAction<Vector3> OnEventRaised;

    public void RaiseEvent(Vector3 value)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(value);
    }
}