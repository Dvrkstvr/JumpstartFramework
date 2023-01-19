using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Vector3Reference))]
public class Vector3ReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        VariableReferenceDrawer.OnGUI(position, property, label);
    }
}