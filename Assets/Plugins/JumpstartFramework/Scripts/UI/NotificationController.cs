using UnityEngine;

public class NotificationController : MonoBehaviour
{
    [SerializeField] private NotificationUIEventSO _notificationChannelSO;

    [SerializeField] private float _notificationAmount;
    [SerializeField] private Vector3 _notificationSpawnPosition;
    [SerializeField] private Transform _notificationContainer;

    [SerializeField] private FloatReference _notificationHeight;
    [SerializeField] private GameObject _infoNotificationPrefab;
    [SerializeField] private GameObject _messageNotificationPrefab;
    [SerializeField] private GameObject _warningNotificationPrefab;

    private void OnEnable()
    {
        _notificationChannelSO.OnEventRaised += DisplayNotification;
    }
    private void OnDisable()
    {
        _notificationChannelSO.OnEventRaised -= DisplayNotification;
    }

    private void DisplayNotification(Notification notification)
    {
        var newNotification = Instantiate(_warningNotificationPrefab, _notificationSpawnPosition, Quaternion.identity, _notificationContainer);
        var newYPosition = (_notificationHeight / 2) + (_notificationAmount * _notificationHeight);
        Vector3 newPosition = new Vector3(0, newYPosition, 0); 
        newNotification.transform.position = Vector3.Lerp(newNotification.transform.position, newPosition, notification.Duration);
    }
}