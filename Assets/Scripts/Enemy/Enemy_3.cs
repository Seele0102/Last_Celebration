using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_3 : MonoBehaviour
{
    private GameObject Player;
    private Vector3 Direction;
    public float Health, Attack, Defence, Speed;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Health = 200 * GameManager.HealthRise;
        Attack = 5 * GameManager.AttRise;
        Defence = 50 * GameManager.DefRise;
    }
    private void Update()
    {
        Direction = gameObject.transform.position - Player.transform.position;
        Direction = Direction.normalized;
        MoveLogic();
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void MoveLogic()
    {
        gameObject.transform.position += Direction * Speed;
    }
}
