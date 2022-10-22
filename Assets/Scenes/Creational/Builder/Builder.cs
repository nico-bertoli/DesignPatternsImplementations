using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour, IBuilder
{
    [Header("Body Parts")]
    [SerializeField] GameObject headPrefab;
    [SerializeField] GameObject bodyPrefab; 
    [SerializeField] GameObject armsPrefab;
    [SerializeField] GameObject legsPrefab;

    public void BuildHead() {
        Instantiate(headPrefab, new Vector3(transform.position.x, transform.position.y +0.8f,transform.position.z), Quaternion.identity).SetActive(true);
    }
    public void BuildBody() {
        Instantiate(bodyPrefab, transform.position, Quaternion.identity);
    }

    public void BuildArms() {
        Instantiate(armsPrefab, transform.position, Quaternion.identity);
    }
    public void BuildLegs() {
        Instantiate(legsPrefab, transform.position, Quaternion.identity);
    }

    public void Register() {
        BuildController.Instance.RegisterBuilder(this);
    }
}