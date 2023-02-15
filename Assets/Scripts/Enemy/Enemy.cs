using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject Player;
    public float Health;
    public float MoveSpeed;
    public Vector3 p;
    public bool AttackAllow=true;
    private Quaternion Turn;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Health = 100f;
    }
    private void Update()
    {
        if(Health<=0)
        {
            Destroy(gameObject);
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            Health -= 10f;
        }
        p = Player.transform.position - gameObject.transform.position;
        p=p.normalized;
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
        if (Input.GetKeyUp(KeyCode.P))
        {
            AttackAllow=!AttackAllow;
        }
    }
}
