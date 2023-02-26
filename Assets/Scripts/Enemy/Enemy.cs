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
    private SpriteRenderer SR;
    private Color originalColor;
    private float timer = 0;
    private bool Att = false;
    private void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        originalColor = SR.color;
        Player = GameObject.FindGameObjectWithTag("Player");
        Health = 100*GameManager.HealthRise;
        Attack = 10*GameManager.AttRise;
        Defence = 10*GameManager.DefRise;
    }
    private void Update()
    {
        if(Health<=0)
        {
            Destroy(gameObject);
        }
        MoveLogic();
        if (SR.color == Color.red && !Att)
        {
            Att = true;
            timer = 0.2f;
        }
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        else if (SR.color == Color.red)
        {
            SR.color = originalColor;
            Att = false;
        }
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
        p = Player.transform.position - gameObject.transform.position;
        p = p.normalized;
        if (AttackAllow)
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
