using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2 : MonoBehaviour
{
    private GameObject Player;
    private Vector3 Direction;
    public float Health, Attack, Defence,Speed,MaxHealth;
    private bool HaveSkill;
    private float AttackCD;
    private Quaternion Turn;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Health=MaxHealth = 200*GameManager.HealthRise;
        Attack = 5 * GameManager.AttRise;
        Defence = 50 * GameManager.DefRise;
        HaveSkill= false;
    }
    private void Update()
    {
        Direction=gameObject.transform.position-Player.transform.position;
        Direction = Direction.normalized;
        MoveLogic();
        Skill();
        if(Health<=0)
        {
            Destroy(gameObject);
        }
        if(AttackCD>=0)
        {
            AttackCD-=Time.deltaTime;
        }
    }
    private void MoveLogic()
    {
        gameObject.transform.position -= Direction*Speed*Time.deltaTime;
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
    }
    private void Skill()
    {
        if(!HaveSkill&&Health<=MaxHealth/4)
        {
            HaveSkill= true;
            Health = MaxHealth * 0.75f;
        }
    }
}
