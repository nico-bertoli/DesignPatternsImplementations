using UnityEngine;

class ClonableChicken : MonoBehaviour, IPrototype {

    private static bool isFirstChicken = true;
    private Value value;

    private void Awake() {
        value = new Value();

        if (isFirstChicken) {
            Debug.Log("prototype initialized with value: " + value.MyVal);
            isFirstChicken = false;
        } 
    }

    public IPrototype Clone() {
        ClonableChicken ris = Instantiate(this,new Vector3(transform.position.x+3,transform.position.y,transform.position.z),Quaternion.identity);

        ris.value = new Value(value.MyVal);

        ris.GetComponent<Rigidbody>().useGravity = true;
        MyUtils.SetRandomSpeed(ris.gameObject, 30);
        return ris;
    }
    /// <summary>
    /// called by button
    /// </summary>
    public void CloneVoid() {
        Clone();
    }

    public void IncreaseVal() {
        value.increaseVal();
    }
}

class Value {
    public int MyVal { get; private set; }

    public Value() {
        MyVal = 0;
    }
    public Value(int _val) {
        MyVal = _val; Debug.Log("clone created with val:" + MyVal);
    }

    public void increaseVal() {
        MyVal++;
        Debug.Log("prototype val increased: " + MyVal);
    }
}