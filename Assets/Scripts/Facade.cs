using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    Factory1 factory1;
    Factory2 factory2;
    Factory3 factory3;
    GameObject go;
    GameObject lastObject;

    private void Awake()
    {
        factory1 = GetComponent<Factory1>();
        factory2 = GetComponent<Factory2>();
        factory3 = GetComponent<Factory3>();
    }



    public void GetObject1()
    {
        if (go == null)
        {
            go = Instantiate(factory1.SendObject(), this.transform);
        }
        else
        {
            lastObject = go;
            Destroy(lastObject);
            go = Instantiate(factory1.SendObject(), this.transform);
        }

    }

    public void GetObject2()
    {
        if (go == null)
        {
            go = Instantiate(factory2.SendObject(), this.transform);
        }
        else
        {
            lastObject = go;
            Destroy(lastObject);
            go = Instantiate(factory2.SendObject(), this.transform);
        }
    }

    public void GetObject3()
    {
        if (go == null)
        {
            go = Instantiate(factory3.SendObject(), this.transform);
        }
        else
        {
            lastObject = go;
            Destroy(lastObject);
            go = Instantiate(factory3.SendObject(), this.transform);
        }
    }



}

