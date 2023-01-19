using UnityEngine;

public class Notification : MonoBehaviour
{
    public RuntimeSet<Notification> RuntimeSet;
    private void OnEnable()
    {
        RuntimeSet.Add(this);
    }
    private void OnDisable()
    {
        RuntimeSet.Remove(this);
    }

    public NotificationType Type;
    public string Message;
    public float Duration;
}
