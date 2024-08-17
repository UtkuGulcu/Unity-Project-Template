using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AddMenuHelper))]
public class AddMenuEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var menuService = (AddMenuHelper)target;

        if (GUILayout.Button("Add Menu"))
        {
            menuService.AddMenu();
        }
    }
}
