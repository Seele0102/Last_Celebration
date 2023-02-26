using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public bool isGet=false;
    private void Update()
    {
        Collecion_1();
    }
    private void Collecion_1()
    {
        if(isGet)
        {
            isGet = false;
            GameManager.AttRise *= 1.2f;
            GameManager.DefRise *= 0.8f;
        }
    }
}
