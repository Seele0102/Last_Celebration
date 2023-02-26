using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Enemy_3 : MonoBehaviour
{
    public GameObject Player,Bullet;
    public float Distance;
    public Vector3 Direction;
    public float Speed, Health, Attack, Defence;
    private float AttackTimer;
    private Quaternion Turn;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        AttackTimer = 5;
    }
    private void Update()
    {
        Prepare();
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        Move();
        AttackBehavior();
        if(AttackTimer> 0)
        {
            AttackTimer-= Time.deltaTime;
        }
    }
    private void Prepare()
    {
        Speed = 1;
        Health = 100*GameManager.HealthRise;
        Attack = 10*GameManager.AttRise;
        Defence = 10*GameManager.DefRise;
        Direction=Player.transform.position-gameObject.transform.position;
        Distance=Vector3.Distance(Direction,Vector3.zero);
        Direction=Direction.normalized;
    }
    private void Move()
    {
        if (Direction.x > 0)
        {
            Turn.SetFromToRotation(new Vector3(1, 0, 0), new Vector3(-1, 0, 0));
            gameObject.transform.rotation = Turn;
        }
        else if (Direction.x < 0)
        {
            Turn.SetFromToRotation(new Vector3(1, 0, 0), new Vector3(1, 0, 0));
            gameObject.transform.rotation = Turn;
        }
        if (Distance<=2)
        {
            gameObject.transform.position -= Speed * Time.deltaTime * Direction;
        }
        else if(Distance>=2.2f)
        {
            gameObject.transform.position += Speed * Time.deltaTime * Direction;
        }
    }
    private void AttackBehavior()
    {
        if (AttackTimer <= 0)
        {
            AttackTimer = 5;
            GameObject.Instantiate(Bullet);
        }
    }
}
