using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaterpillarFactory : AbsAnimalFactory {
    public override void CreateAnimal() {
        base.CreateAnimal();
        Debug.Log("doing specific instantiation operations for caterpillar");
    }
}
