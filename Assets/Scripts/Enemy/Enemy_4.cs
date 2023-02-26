using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Enemy_4 : MonoBehaviour
{
    private GameObject Player,Bullet,Enemy;
    public float Health, Attack, Defence, Speed;
    public float SkillTimer;
    public float Distance;
    public Vector3 Direction;
    public int EnemyNumber;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        SkillTimer = 10;
        EnemyNumber = 0;
    }
    private void Update()
    {
        Prepare();
        if (Health <= 0)
        {
            GameObject.Instantiate(Bullet);
            GameObject.Instantiate(Enemy);
            Destroy(gameObject);
        }
        Move();
        Skill();
        if (SkillTimer > 0)
        {
            SkillTimer -= Time.deltaTime;
        }
    }
    private void Prepare()
    {
        Speed = 1;
        Health = 100 * GameManager.HealthRise;
        Attack = 10 * GameManager.AttRise;
        Defence = 10 * GameManager.DefRise;
        Direction = Player.transform.position - gameObject.transform.position;
        Distance = Vector3.Distance(Direction, Vector3.zero);
        Direction = Direction.normalized;
    }
    private void Move()
    {
        if (Distance <= 2)
        {
            gameObject.transform.position -= Speed * Time.deltaTime * Direction;
        }
        else if (Distance >= 2.2f)
        {
            gameObject.transform.position += Speed * Time.deltaTime * Direction;
        }
    }
    private void Skill()
    {
        if (SkillTimer <= 0&&EnemyNumber<=3)
        {
            SkillTimer = 10;
            GameObject.Instantiate(Enemy);
            EnemyNumber++;
        }
    }
}
