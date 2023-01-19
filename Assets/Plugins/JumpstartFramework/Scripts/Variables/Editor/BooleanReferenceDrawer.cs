using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(BooleanReference))]
public class BooleanReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        VariableReferenceDrawer.OnGUI(position, property, label);
    }
}