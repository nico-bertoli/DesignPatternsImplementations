using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenFactory : AbsAnimalFactory {

    public override Animal CreateAnimal() {
        Debug.Log("doing specific instantiation operations for chicken");
        return base.CreateAnimal();
    }

}
