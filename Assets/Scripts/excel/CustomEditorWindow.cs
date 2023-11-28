using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace TrafficInfinity
{
    public class CustomEditorWindow : EditorWindow
    {
        [MenuItem("Tools/CustomWindow")]

        public static void ShowWindow()
        {
            GetWindow<CustomEditorWindow>("CustomEditorWindow");
        }



        private void OnGUI()
        {
            GUILayout.Label("Reload Item Database", EditorStyles.boldLabel);
            if (GUILayout.Button("Reload Items"))
            {
                GameObject.Find("Database").GetComponent<LoadExcel>().LoadItemData();
                //GetComponent<TrafficInfinity.LoadExcel>().LoadItemData();
            }

        }

    }
}
