using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChickenFactory : AbsAnimalFactory {

    public override Animal CreateAnimal() {
        Debug.Log("CHICKEN FACTORY: executing instantiation operations for chicken");
        return base.CreateAnimal();
    }

}
