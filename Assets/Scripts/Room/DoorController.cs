using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool HaveEnterd=false;
    public bool Clear=false;
    private bool Search = false;
    public GameObject[] Doors;
    private float timer=0;
    private void Update()
    {
        if(timer<=1)
        {
            timer += Time.deltaTime;
        }
        if(!Search&&timer>=1)
        {
            Search= true;
            Doors = GameObject.FindGameObjectsWithTag("Door");
        }
        if(Input.GetKeyUp(KeyCode.Space)) 
        {
            Clear= true;
            foreach(var Door in Doors)
            {
                Door.GetComponent<BoxCollider2D>().enabled= false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player") && !HaveEnterd)
        {
            HaveEnterd = true;
            foreach (var Door in Doors)
            {
                Door.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
}
