using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyUtils
{
    public static void SetRandomSpeed(GameObject obj,int random) {
        obj.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-random, random+1)/10f, 0, 0);
    }
}
