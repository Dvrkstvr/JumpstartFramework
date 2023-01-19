using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/BooleanGameEvent")]
public class BooleanGameEventSO : ScriptableObject
{
    public event UnityAction<bool> OnEventRaised;

    public void RaiseEvent(bool value)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(value);
    }
}