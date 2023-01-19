using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Vector2Reference))]
public class Vector2tReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        VariableReferenceDrawer.OnGUI(position, property, label);
    }
}