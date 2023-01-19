using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NotificationUIEventSO))]
public class NotificationUIEventEditor : Editor
{
    private Notification notification;
    [SerializeField]
    public NotificationType Type;
    [SerializeField]
    public string Message;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        NotificationUIEventSO e = target as NotificationUIEventSO;

        Type = (NotificationType)EditorGUILayout.EnumPopup("Type", Type);

        Message = EditorGUILayout.TextField("Message", Message);

        // make new notification object
        //notification = new Notification();
        //notification.Type = Type;
        //notification.Message = Message;
        //notification.Duration = 2f;

        if (GUILayout.Button("Raise"))
        {
            e.OnEventRaised(notification);
        }
    }
}