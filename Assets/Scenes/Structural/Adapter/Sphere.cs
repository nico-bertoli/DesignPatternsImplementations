using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

class Sphere : MonoBehaviour, ISphere{

    private float radius;
    private void Update() {
        radius = GetComponent<SphereCollider>().radius;
    }

    [DrawGizmo(GizmoType.NotInSelectionHierarchy)]
    private static void DrawGizmo(Sphere source, GizmoType type) {
        Gizmos.DrawWireSphere(source.transform.position, source.GetComponent<SphereCollider>().radius);
    }

    public float GetRadius() {
        return radius;
    }
}
