using UnityEngine;
using UnityEngine.Events;

public class AchievementStatus : MonoBehaviour
{
    public Achievement achievement;

    public UnityEvent OnUnlocked;

    private void Start()
    {
        Unlock();
    }

    public void Unlock()
    {
        if (achievement.isUnlocked == true)
        {
            OnUnlocked.Invoke();
        }
    }
}
