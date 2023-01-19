using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName ="Achievement", menuName ="Achievement")]
public class Achievement : ScriptableObject
{
    public bool isUnlocked = false;

    public GameEventSO AchievementConditionMet = default;
    public GameEventSO onUnlocked = default;

    void Unlock()
    {
        isUnlocked = true;
    }
}