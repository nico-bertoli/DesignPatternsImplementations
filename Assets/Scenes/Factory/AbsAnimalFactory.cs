using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsAnimalFactory : MonoBehaviour
{
    [SerializeField] protected GameObject animalPrefab;
    public virtual Animal CreateAnimal() {
        Animal ris = Instantiate(animalPrefab, transform.position, Quaternion.identity).GetComponent<Animal>();
        ris.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-10, 11) / 10f, 0, 0);
        return ris;
    }
    /// <summary>
    /// used by buttons
    /// </summary>
    public void CreateAnimalVoid() {
        CreateAnimal();
    }
}
