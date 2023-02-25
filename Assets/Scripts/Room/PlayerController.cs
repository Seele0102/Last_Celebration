using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;

    Animator anim;

    Vector2 movement;

    public float speed;

    public GameObject player;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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





}
