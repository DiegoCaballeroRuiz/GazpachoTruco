using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ResourceAddingBuilding))]
public class ResourceAddingBuildingCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ResourceAddingBuilding resourceAdder = (ResourceAddingBuilding)target;

        base.OnInspectorGUI();

        GUILayout.Label("Debug:");

        if (GUILayout.Button("Add 1 Building")) resourceAdder.AddBuildings(1);
        if (GUILayout.Button("Remove 1 Building")) resourceAdder.RemoveBuildings(1);
    }
}
