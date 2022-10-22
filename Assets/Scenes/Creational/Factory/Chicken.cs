using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Chicken : Animal
{
    protected override void Sound() {
        Debug.Log("Cluck");
    }
}
