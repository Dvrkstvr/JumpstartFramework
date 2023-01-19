using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(IntegerReference))]
public class IntegerReferenceDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        VariableReferenceDrawer.OnGUI(position, property, label);
    }
}