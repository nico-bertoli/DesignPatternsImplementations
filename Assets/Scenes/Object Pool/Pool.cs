using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : Singleton<Pool>
{
    [Header("Settings")]
    [SerializeField] int startPoolSize;

    [Header("References")]
    [SerializeField] GameObject pooledObject;

    int availableElementsCount;
    int poolSize;
    List<GameObject> pool = new List<GameObject>();
    List<bool> poolAailability = new List<bool>();

    protected override void Awake() {
        base.Awake();
        poolSize = 0;
        availableElementsCount = 0;

        IncreaseSize(startPoolSize);
    }

    public GameObject AcquireReusable() {

        if (availableElementsCount == 0) {
            IncreaseSize(startPoolSize);
        }

        for (int i = 0; i < poolSize; i++) {
            if (poolAailability[i]) {
                poolAailability[i] = false;
                availableElementsCount--;
                pool[i].SetActive(true);
                return pool[i];
            }
        }

        return null;    
    }

    public void ReleaseReusable(GameObject reusable) {
        for(int i = 0; i < poolSize; i++) {
            if (pool[i].gameObject == reusable) {
                poolAailability[i] = true;
                reusable.SetActive(false);
                availableElementsCount++;
            }
        }
    }

    private void IncreaseSize(int _increaseAmmount) {

        poolSize += _increaseAmmount;
        availableElementsCount += _increaseAmmount;

        for (int i = 0; i < _increaseAmmount; i++) {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            obj.transform.parent = transform;
            pool.Add(obj);
            poolAailability.Add(true);
        }
    }

}
