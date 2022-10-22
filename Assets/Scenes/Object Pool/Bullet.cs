using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    public void Shot(Vector3 _direction, float _speed) {
        rb.velocity = _direction.normalized * _speed;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag != "Bullet")
            Pool.Instance.ReleaseReusable(gameObject);
    }
}
