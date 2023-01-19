using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/IntGameEvent")]
public class IntGameEventSO : ScriptableObject
{
    public UnityAction<int> OnEventRaised;

    public void RaiseEvent(int value)
    {
        if(OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
    }
}
