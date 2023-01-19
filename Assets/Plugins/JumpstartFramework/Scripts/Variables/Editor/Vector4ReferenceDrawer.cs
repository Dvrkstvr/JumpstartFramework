using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Vector4Reference))]
public class Vector4ReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        VariableReferenceDrawer.OnGUI(position, property, label);
    }
}