using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaterpillarFactory : AbsAnimalFactory {
    public override Animal CreateAnimal() {
        Debug.Log("doing specific instantiation operations for caterpillar");
        return base.CreateAnimal();
    }
}
