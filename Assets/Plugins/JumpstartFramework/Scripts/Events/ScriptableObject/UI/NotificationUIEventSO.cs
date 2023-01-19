using UnityEngine;
using UnityEngine.Events;

public enum NotificationType
{
	Info,
	Message,
	Alert
}

[CreateAssetMenu(menuName = "Events/UI/Notification Event")]
public class NotificationUIEventSO : ScriptableGameObject
{
	public UnityAction<Notification> OnEventRaised;

	public void AddNotification(Notification notification)
	{
		Notification(notification);
	}

	private void Notification(Notification notification)
	{
		if (OnEventRaised != null)
			OnEventRaised.Invoke(notification);
	}
}