using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public GameObject Enemy_1, Enemy_2, Enemy_3, Enemy_4, Enemy_SP_1, Enemy_SP_2, Enemy_SP_3, Enemy_SP_4;
    public GameObject EnemyCreateCenter;
    public int EnemyNum;
    private int RoomNumber;
    public bool HaveEnterd=false;
    public bool Clear=false;
    public GameObject[] Doors;
    private float timer=0;
    private GameObject X_Enemy;
    private float Random_X, Random_Y;
    private void Start()
    {
        Doors = GameObject.FindGameObjectsWithTag("Door");
        EnemyNum = Random.Range(2, 10);
    }
    private void Update()
    {
        if (HaveEnterd && timer <= 0 && EnemyNum>0) 
        {
            timer=Random.Range(0.5f,2);
            EnemyNum--;
            Random_X = Random.Range(-8, 8);
            Random_Y=Random.Range(-3, 3);
            X_Enemy = Instantiate(Enemy_1);
            X_Enemy.transform.parent = EnemyCreateCenter.transform;
            X_Enemy.transform.localPosition = new Vector3(Random_X, Random_Y, 0);
        }
        else if(timer>0)
        {
            timer-=Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Q)) 
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
//本代码首先对prefab中的敌人进行调用
//再读取