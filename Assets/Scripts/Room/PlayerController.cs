using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    Animator anim;

    Vector2 movement;

    public float speed;

    public GameObject player;

    public float Def, Att, Health;
    public GameObject Bullet;
    public float timer,timer_2;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        timer =timer_2= 0;
        Health = 100;
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x != 0)
        {
            transform.localScale = new Vector3(movement.x, 1, 1);
        }

        SwitchAnim();
        if(timer>0)
        {
            timer-= Time.deltaTime;
        }
        if(timer_2>0)
        {
            timer_2-= Time.deltaTime;
        }
        Attack();
        if(Health<=0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void SwitchAnim()
    {
        anim.SetFloat("speed",movement.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(PlayEffect());
        SavePos(0, 2, 0);
    }

    IEnumerator PlayEffect()
    {
        yield return new WaitForSeconds(2.0f);
        Application.LoadLevel("copyOne");
        DontDestroyOnLoad(player);
    }

    void SavePos(float posX,float posY,float posZ)
    {
        PlayerPrefs.SetFloat("PosX",posX);
        PlayerPrefs.SetFloat("PosY", posY);
        PlayerPrefs.SetFloat("PosZ", posZ);
    }

    void LoadPos()
    {
        float x = PlayerPrefs.GetFloat("PosX");
        float y = PlayerPrefs.GetFloat("PosY");
        float z = PlayerPrefs.GetFloat("PosZ");
        transform.localPosition = new Vector3((float)x, (float)y, (float)z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Enemy"))
        {
            Health -= 10;
            timer_2 = 1;
        }
    }
    private void Attack()
    {
        if(Input.GetKeyDown(KeyCode.J)&&timer<=0)
        {
            GameObject.Instantiate(Bullet);
            timer = 0.5f;
        }
    }
}
