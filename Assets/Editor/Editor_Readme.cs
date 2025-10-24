using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ReadMeSO))]
public class Editor_Readme : Editor
{
    SerializedProperty TextProperty;
    SerializedProperty ModeProperty;
     SerializedProperty HeaderProperty;
    bool mode = true;
    void OnEnable()
    {
        TextProperty = serializedObject.FindProperty("text");
        HeaderProperty = serializedObject.FindProperty("header");
        ModeProperty = serializedObject.FindProperty("Edit_Me");
        // Debug.Log(ReadOnlyProperty);
    }

    public override void OnInspectorGUI()
    {
        
        int k = 7;
        serializedObject.Update();
        EditorGUILayout.PropertyField(ModeProperty);
        EditorGUILayout.Space(5f);


        string text = "";
        string header = "";
        if (TextProperty != null)
            text = (string)TextProperty.stringValue;
        if (ModeProperty != null)
            mode = (bool)ModeProperty.boolValue;
        if (HeaderProperty != null)
            header=(string)HeaderProperty.stringValue;
            GUIStyle Header_Style = new GUIStyle(EditorStyles.boldLabel)
            {
                fontSize = 18,
                wordWrap = true,
               
            };

            GUIStyle Text_Style = new GUIStyle(EditorStyles.boldLabel)
            {
                fontSize = 14,
                wordWrap = true,
               
            };
        Header_Style.normal.textColor = Color.green;
        if (mode)
        {

            EditorGUILayout.PropertyField(HeaderProperty);
            EditorGUILayout.Space(10f);

            EditorGUILayout.PropertyField(TextProperty);
            EditorGUILayout.LabelField("For going next line use \\n ",GUILayout.Height(30));

        }
        else
        {
            EditorGUILayout.LabelField(header, Header_Style);
            EditorGUILayout.Space(20f);
            string[] texts;
            texts = text.Split("\\n");

            foreach (var T in texts)
            {
                // if(T[0].Equals(" "))
                // { T.Trim(' '); }
                EditorGUILayout.LabelField(T, Text_Style);
            }



        }
        serializedObject.ApplyModifiedProperties();
    }
}
