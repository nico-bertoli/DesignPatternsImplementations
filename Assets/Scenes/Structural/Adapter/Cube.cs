using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

class Cube : MonoBehaviour
{
    public float Width { get; private set; }

    private void Update() {
        Width = GetComponent<BoxCollider>().size.x;
    }


    [DrawGizmo(GizmoType.NotInSelectionHierarchy)]
    private static void DrawGizmo(Cube source, GizmoType type) {
        Gizmos.DrawWireCube(source.transform.position, source.GetComponent<BoxCollider>().size);
    }
}
