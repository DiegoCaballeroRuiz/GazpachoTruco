using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GazpachoContainer))]
public class GazpachoCOntainerCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GazpachoContainer container = (GazpachoContainer)target;

        base.OnInspectorGUI();
        if (GUILayout.Button("Reset")) container.GazpachoLiters = 0;
    }
}
