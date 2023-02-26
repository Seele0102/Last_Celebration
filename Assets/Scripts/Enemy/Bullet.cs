using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject ShootCenter;
    public Vector3 Dircetion;
    private float timer;
    private void Awake()
    {
        ShootCenter = GameObject.FindGameObjectWithTag("ShootCenter");
        gameObject.transform.parent = ShootCenter.transform;
        gameObject.transform.localPosition = Vector3.zero;
    }
    private void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Dircetion=gameObject.transform.position-Enemy.transform.position;
        Dircetion = Dircetion.normalized;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        gameObject.transform.position -= Dircetion*Time.deltaTime*9;
        if(timer>=4)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Enemy"))
        {
            if(collision.GetComponent<Enemy>() != null)
            {
                collision.GetComponent<Enemy>().Health -= 1000;
            }
            else if(collision.GetComponent<Enemy_2>() != null) 
            { 
                collision.GetComponent <Enemy_2>().Health -= 500;
            }
            Destroy(gameObject);
        }
    }
}
