using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(FloatReference))]
public class FloatReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        VariableReferenceDrawer.OnGUI(position, property, label);
    }
}