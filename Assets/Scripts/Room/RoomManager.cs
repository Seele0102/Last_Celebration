using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class RoomManager : MonoBehaviour
{
    public GameObject Enemy_1, Enemy_2, Enemy_3, Enemy_4, Enemy_SP;
    public GameObject EnemyCreateCenter;
    public int EnemyNum=0,EnemyNum_2=0,EnemyNum_3=0,EnemyNum_4 = 0;
    public bool HaveEnterd=false;
    public bool Clear=false;
    public GameObject[] Doors;
    private float timer=0,timer_2=0,timer_3=0,timer_4=0;
    private GameObject X_Enemy;
    private float Random_X = 0, Random_Y = 0;
    public GameObject Box,X_Box;
    private void Start()
    {
        Doors = GameObject.FindGameObjectsWithTag("Door");
        EnemyNum = Random.Range(2, 20);
        EnemyNum_2= Random.Range(2, 20);
        if(GameManager.GameLevel>=1)
        {
            EnemyNum_3= Random.Range(2, 10);
            if(GameManager.GameLevel>=2)
            {
                EnemyNum_4= Random.Range(2, 10);
            }
        }
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
        if(HaveEnterd&&timer_2<=0&&EnemyNum_2>0)
        {
            timer_2 = Random.Range(0.5f, 2);
            EnemyNum_2--;
            Random_X = Random.Range(-8, 8);
            Random_Y = Random.Range(-3, 3);
            X_Enemy = Instantiate(Enemy_2);
            X_Enemy.transform.parent = EnemyCreateCenter.transform;
            X_Enemy.transform.localPosition = new Vector3(Random_X, Random_Y, 0);
        }
        else if(timer_2>0)
        {
            timer_2-=Time.deltaTime;
        }
        if(HaveEnterd&&timer_3<=0&&EnemyNum_3>0)
        {
            timer_3 = Random.Range(0.5f, 2);
            EnemyNum_3--;
            Random_X = Random.Range(-8, 8);
            Random_Y = Random.Range(-3, 3);
            X_Enemy = Instantiate(Enemy_3);
            X_Enemy.transform.parent = EnemyCreateCenter.transform;
            X_Enemy.transform.localPosition = new Vector3(Random_X, Random_Y, 0);
        }
        else if (timer_3 > 0)
        {
            timer_3-=Time.deltaTime;
        }
        if (HaveEnterd && timer_4 <= 0 && EnemyNum_4 > 0)
        {
            timer_4 = Random.Range(0.5f, 2);
            EnemyNum_4--;
            Random_X = Random.Range(-8, 8);
            Random_Y = Random.Range(-3, 3);
            X_Enemy = Instantiate(Enemy_4);
            X_Enemy.transform.parent = EnemyCreateCenter.transform;
            X_Enemy.transform.localPosition = new Vector3(Random_X, Random_Y, 0);
        }
        else if(timer_4 > 0)
        {
            timer_4-=Time.deltaTime;
        }
        if (EnemyCreateCenter.transform.childCount==0&&EnemyNum==0&&EnemyNum_2==0&&EnemyNum_3==0&&EnemyNum_4==0&&!Clear) 
        {
            Clear= true;
            X_Box=GameObject.Instantiate(Box);
            X_Box.transform.parent=EnemyCreateCenter.transform;
            X_Box.transform.localPosition = Vector3.zero;
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