using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FloatGameEventSO))]
public class FloatEventEditor : Editor
{
    [SerializeField]
    public float Value;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        FloatGameEventSO e = target as FloatGameEventSO;

        // add variable input field
        // parse into value

        if (GUILayout.Button("Raise"))
        {
            e.RaiseEvent(Value);
        }
    }
}