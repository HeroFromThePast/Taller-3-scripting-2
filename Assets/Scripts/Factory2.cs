using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory2 : MonoBehaviour
{
    [SerializeField] GameObject objectToInstantiate;
    Facade facade;

    private void Awake()
    {
        facade = GetComponent<Facade>();
    }

    public GameObject SendObject()
    {
        return objectToInstantiate;
    }
}
