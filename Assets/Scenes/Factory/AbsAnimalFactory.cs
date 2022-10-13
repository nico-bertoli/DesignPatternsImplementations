using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsAnimalFactory : MonoBehaviour
{
    [SerializeField] protected GameObject animalPrefab;
    public virtual void CreateAnimal() {
        Instantiate(animalPrefab,transform.position,Quaternion.identity).GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-10,11)/10f,0,0);

    }
}
