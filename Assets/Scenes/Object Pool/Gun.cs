using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Gun : MonoBehaviour
{
    [SerializeField] float bulletsPerSecond;
    [SerializeField] float bulletsSpeed;

    float lastShotTime;
    float fireFrequence;

    private void Start() {
        lastShotTime = Time.time;
    }

    private void Update() {

        fireFrequence = 1f / bulletsPerSecond;

        if(Time.time - lastShotTime > fireFrequence) {
            Shot();
            lastShotTime= Time.time;
        }
    }

    private void Shot() {
        GameObject obj = Pool.Instance.AcquireReusable();
        obj.transform.position = transform.position;
        int randomDegrees = Random.Range(-10, 11);
        obj.GetComponent<Bullet>().Shot(Quaternion.AngleAxis(randomDegrees, transform.forward) * transform.up, bulletsSpeed);
    }
}
