using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/GameEvent")]
public class GameEventSO : ScriptableObject
{
    public UnityAction OnEventRaised;

    public void RaiseEvent()
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke();
        }
    }
}
