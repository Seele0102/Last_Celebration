using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject ShootCenter;
    public Vector3 Dircetion;
    private float timer;
    private SpriteRenderer SR;
    private Color originalColor;

    private void Awake()
    {
        ShootCenter = GameObject.FindGameObjectWithTag("ShootCenter");
        gameObject.transform.position = ShootCenter.transform.position; 
    }
    private void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Dircetion=gameObject.transform.position-Enemy.transform.position;
        Dircetion = Dircetion.normalized;
    }
    private void Update()
    {
        if(Time.timeScale ==1)
        {
if (Enemy==null)
        {
            Destroy(gameObject);
        }
        timer += Time.deltaTime;
        gameObject.transform.position -= Dircetion*Time.deltaTime*9;
        if(timer>=4)
        {
            Destroy(gameObject);
        }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Enemy"))
        {
            SR = collision.GetComponent<SpriteRenderer>();
            originalColor= SR.color;
            if (collision.GetComponent<Enemy>() != null)
            {
                collision.GetComponent<Enemy>().Health -= 50 * GameManager.Att;
                FlashColor(0.1f);
            }
            else if(collision.GetComponent<Enemy_2>() != null) 
            { 
                collision.GetComponent <Enemy_2>().Health -= 50 * GameManager.Att;
                FlashColor(0.1f);
            }
            Destroy(gameObject);
        }
    }
    public void FlashColor(float time)
    {
        SR.color = Color.red;
        Invoke("ResetColor", time);
    }

    public void ResetColor()
    {
        SR.color = originalColor;
    }
}
