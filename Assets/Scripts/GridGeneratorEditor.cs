using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;



[CustomEditor(typeof(GridGenerator))]
public class GridGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GridGenerator gridGenerator = (GridGenerator)target;
        if (GUILayout.Button("Generate Grid"))
        {
            gridGenerator.GenerateGrid();
        }

        if (GUILayout.Button("Clear Grid"))
        {
            gridGenerator.ClearGrid();
        }

        if (GUILayout.Button("Assign Material"))
        {
            gridGenerator.AssignMaterial();
        }
        if (GUILayout.Button("Assign Tile Script"))
        {
            gridGenerator.AssignTileScript();
        }
    }
}
