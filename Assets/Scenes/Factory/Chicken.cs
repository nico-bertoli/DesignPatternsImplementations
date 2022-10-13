using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : AbsAnimal
{
    protected override void Sound() {
        Debug.Log("Cluck");
    }
}
