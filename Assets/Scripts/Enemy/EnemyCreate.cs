using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    public DoorController DC;
    private void Start()
    {
        DC=gameObject.GetComponent<DoorController>();
    }
    private void Update()
    {
        if(DC.HaveEnterd)
        {

        }
    }
}
