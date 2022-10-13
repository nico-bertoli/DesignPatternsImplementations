using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFactory : AbsAnimalFactory {

    public override void CreateAnimal() {
        base.CreateAnimal();
        Debug.Log("doing specific instantiation operations for chicken");
    }
}
