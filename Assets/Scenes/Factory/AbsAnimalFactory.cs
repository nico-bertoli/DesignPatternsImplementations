using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class AbsAnimalFactory : MonoBehaviour
{
    [SerializeField] protected GameObject animalPrefab;
    public virtual Animal CreateAnimal() {
        Animal ris = Instantiate(animalPrefab, transform.position, Quaternion.identity).GetComponent<Animal>();
        MyUtils.SetRandomSpeed(ris.gameObject, 20);
        return ris;
    }
    /// <summary>
    /// used by buttons
    /// </summary>
    public void CreateAnimalVoid() {
        CreateAnimal();
    }
}
