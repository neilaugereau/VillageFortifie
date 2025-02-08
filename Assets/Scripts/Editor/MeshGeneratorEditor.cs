using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MeshGenerator))]
public class MeshGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MeshGenerator meshGenerator = (MeshGenerator)target;

        if (GUILayout.Button("Generate Terrain"))
        {
            meshGenerator.CreateNewMap();
        }
    }
}