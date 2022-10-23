using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class SquareSphereAdapter : MonoBehaviour, ISphere {

    Cube cube;

    private void Awake() {
        cube = GetComponent<Cube>();
    }

    public float GetRadius() {
        return cube.Width * Mathf.Sqrt(2) / 2;
    }

}
