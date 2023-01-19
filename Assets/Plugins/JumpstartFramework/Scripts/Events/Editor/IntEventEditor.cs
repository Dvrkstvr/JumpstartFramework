using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IntGameEventSO))]
public class IntEventEditor : Editor
{
    [SerializeField]
    public int Value;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        IntGameEventSO e = target as IntGameEventSO;
        if (GUILayout.Button("Raise"))
        {
            e.RaiseEvent(Value);
        }
    }
}