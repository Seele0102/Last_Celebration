using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Enemy_4 : MonoBehaviour
{
    private int EnemyNum;
    private GameObject[] Enemies;
    private float CureTimer;
    private GameObject Player;
    private GameObject Bullet_attack;
    public int Health;
    private Vector3 p;
    private void Awake()
    {
        EnemyNum = 1;
        CureTimer = 0;
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (Enemies==null||Health<=0) 
        {
            GameObject.Instantiate(Bullet_attack);
            Destroy(gameObject);
        }
        else if (CureTimer <= 0) 
        {
            //compare
            CureTimer = 5;
        }
        else
        {
            CureTimer-=Time.deltaTime;
        }
        Move();
    }
    private void Move()
    {
        p = Player.transform.position - gameObject.transform.position;
        p = p.normalized;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) 
        {
            Enemies[EnemyNum++]=collision.gameObject;
        }
    }
}
