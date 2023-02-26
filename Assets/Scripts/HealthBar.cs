using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image hpImage;
    public Image hpEffectImage;
    public float hp;
    [SerializeField] private float maxHp;
    [SerializeField] private float hurtSpeed=0.005f;
    public GameObject Player;
    public PlayerController PVC;
    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        PVC= Player.GetComponent<PlayerController>();
        maxHp=100;
    }
    private void Update()
    {
        hp=PVC.Health;
        hpImage.fillAmount = hp/maxHp ;
        if(hpEffectImage.fillAmount > hpImage.fillAmount)
        {
            hpEffectImage.fillAmount -= hurtSpeed;
        }
        else
        {
            hpEffectImage.fillAmount = hpImage.fillAmount;
        }
    }
}
