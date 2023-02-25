using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject Player;
    public float Health,Attack,Defence,MoveSpeed;
    public Vector3 p;
    public bool AttackAllow=true;
    private Quaternion Turn;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Health = 100f;
        Attack = 10;
        Defence = 10;
    }
    private void Update()
    {
        if(Health<=0)
        {
            Destroy(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            Health -= 100;
        }
        MoveLogic();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            AttackAllow = false;
        }
    }
    private void MoveLogic()
    {
        p = gameObject.transform.position - Player.transform.position;
        p = p.normalized;
        if (!AttackAllow)
        {
            p = -p;
        }
        if (p.x < 0)
        {
            Turn.SetFromToRotation(new Vector3(1, 0, 0), new Vector3(-1, 0, 0));
            gameObject.transform.rotation = Turn;
        }
        else if (p.x > 0)
        {
            Turn.SetFromToRotation(new Vector3(1, 0, 0), new Vector3(1, 0, 0));
            gameObject.transform.rotation = Turn;
        }
        gameObject.transform.position += MoveSpeed * Time.deltaTime * p;
    }
}
