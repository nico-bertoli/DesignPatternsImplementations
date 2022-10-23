using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CircleHole : MonoBehaviour
{
    private float holeSize;
    private void Awake() {
        holeSize = GetComponent<SphereCollider>().radius;
    }

    private void OnTriggerEnter(Collider other) {
        
        ISphere otherCil = other.GetComponent<ISphere>();

        if (otherCil!=null && otherCil.GetRadius() > holeSize) {
            Debug.Log("stopping other");
            other.GetComponent<Rigidbody>().useGravity = false;
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

}
