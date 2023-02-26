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
    //敌人受伤动画：在减少生命值的代码处添加FlashColor(float time)
    private SpriteRenderer sr;
    private Color originalColor;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Health = 100*GameManager.HealthRise;
        Attack = 10*GameManager.AttRise;
        Defence = 10*GameManager.DefRise;
        sr = GetComponent<SpriteRenderer>();
        originalColor = sr.color;
    }
    private void Update()
    {
        if(Health<=0)
        {
            Destroy(gameObject);
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

    void FlashColor(float time)
    {
        sr.color = Color.red;
        Invoke("ResetColor", time);     
    }

    void ResetColor()
    {
        sr.color = originalColor;
    }




}
