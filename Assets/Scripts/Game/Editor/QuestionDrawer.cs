using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(Questions))]
[CanEditMultipleObjects]
[System.Serializable]
public class QuestionDrawer : Editor
{
    private Questions QInstance => target as Questions;
    private ReorderableList QuestionList;

    private void OnEnable()
    {
        InitializeReorderableList(ref QuestionList, "qList", "QLIST");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        QuestionList.DoLayoutList();
        serializedObject.ApplyModifiedProperties();
    }

    private void InitializeReorderableList(ref ReorderableList list, string propertyName, string listLable)
    {
        list = new ReorderableList(serializedObject, serializedObject.FindProperty(propertyName), true, true, true,true);
        list.onAddCallback = ReorderableList => QInstance.AddQuestion();
        list.drawHeaderCallback = (Rect rect) =>
        {
            EditorGUI.LabelField(rect, listLable);
        };

        var l = list;

        list.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
            var element = l.serializedProperty.GetArrayElementAtIndex(index);
            rect.y += 2;

            EditorGUI.PropertyField(new Rect(rect.x, rect.y, 300, EditorGUIUtility.singleLineHeight), element.FindPropertyRelative("question"), GUIContent.none);

            EditorGUI.PropertyField(new Rect(rect.x + 310, rect.y, 300, EditorGUIUtility.singleLineHeight), element.FindPropertyRelative("isCorrect"), GUIContent.none);
        };
    }
}
