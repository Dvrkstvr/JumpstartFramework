using UnityEditor;
using UnityEngine;

public static class VariableReferenceDrawer
{
    private static readonly string[] _popupOptions =
        {"Use Constant", "Use Variable"};

    private static GUIStyle _popupStyle;

    public static void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (_popupStyle == null)
        {
            _popupStyle = new GUIStyle(GUI.skin?.GetStyle("PaneOptions"))
            {
                imagePosition = ImagePosition.ImageOnly
            };
        }

        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        EditorGUI.BeginChangeCheck();

        SerializedProperty useConstant = property?.FindPropertyRelative("UseConstant");
        SerializedProperty constantValue = property?.FindPropertyRelative("ConstantValue");
        SerializedProperty variable = property?.FindPropertyRelative("Variable");

        Rect constantButtonRect = new Rect(position);
        Debug.Assert(_popupStyle.margin != null, "m_popupStyle.margin != null");
        constantButtonRect.yMin += _popupStyle.margin.top;
        constantButtonRect.width = _popupStyle.fixedWidth + _popupStyle.margin.right;
        position.xMin = constantButtonRect.xMax;

        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        int useConstantResults = EditorGUI.Popup(constantButtonRect, useConstant?.boolValue == true ? 0 : 1, _popupOptions, _popupStyle);

        if (useConstant != null)
        {
            useConstant.boolValue = useConstantResults == 0;

            //SirenixEditorFields.FloatField(position, GUIContent.none, useConstant.boolValue ? constantValue : variable);
            EditorGUI.PropertyField(position, useConstant.boolValue ? constantValue : variable, GUIContent.none);
        }

        if (EditorGUI.EndChangeCheck())
        {
            property?.serializedObject?.ApplyModifiedProperties();
        }

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}