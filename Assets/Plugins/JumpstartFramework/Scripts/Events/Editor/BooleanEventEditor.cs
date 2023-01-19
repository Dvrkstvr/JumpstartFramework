using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BooleanGameEventSO))]
public class BooleanEventEditor : Editor
{
    [SerializeField]
    public bool Value;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        BooleanGameEventSO e = target as BooleanGameEventSO;

        if(GUILayout.Toggle(Value, "Value"))
        {
            Value = !Value;
        }
        
        if (GUILayout.Button("Raise"))
        {
            e.RaiseEvent(Value);
        }
    }
}