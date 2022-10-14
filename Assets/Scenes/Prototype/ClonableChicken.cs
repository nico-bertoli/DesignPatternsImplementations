using System.Collections;
using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;

class ClonableChicken : MonoBehaviour, IPrototype {

    public int value { get; private set;}

    private void Start() {
        Debug.Log("created chicken with value: " + value);
    }

    public IPrototype Clone() {
        ClonableChicken ris = Instantiate(this,new Vector3(transform.position.x+3,transform.position.y,transform.position.z),Quaternion.identity);

        // doesn't make a lot of sense cause Instantiate already clones the object
        // for more advanced things this could be more flexible anyway
        // for example if the chicken had another object associated (and not in his hierarchy, it could be cloned manually here
        ris.value = this.value;

        ris.GetComponent<Rigidbody>().useGravity = true;
        MyUtils.SetRandomSpeed(ris.gameObject, 30);

        return (IPrototype)ris;
    }
    /// <summary>
    /// called by button
    /// </summary>
    public void CloneVoid() {
        Clone();
    }
}
