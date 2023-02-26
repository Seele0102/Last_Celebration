using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Sample : MonoBehaviour
{
    public bool isGet = false;
    public int number = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<PlayerController>().Health = 100;
            GameManager.Att += 0.2f;
        }
    }
    //�ҷ����������
    //HP����10%
    private void Collection_Player_HpRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.1f;
        }
    }
    //HP����20%
    private void Collection_Player_HpRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.2f;
        }
    }

    //HP����50%
    private void Collection_Player_HpRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.5f;
        }
    }

    //HPֵ����100��
    private void Collection_Player_HpPointRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 100f;
        }
    }

    //HP����500��
    private void Collection_Player_HpPointRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 500f;
        }
    }

    //HP����1000��
    private void Collection_Player_HpPointRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 1000f;
        }
    }

    //HP����2000��
    private void Collection_Player_HpPointRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 2000f;
        }
    }

    //�з�����ֵ���
    //�з�����ֵ����5%
    private void Collection_Enemy_HpDown1()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.HealthRise *= 0.95f;
        }
    }

    //�з�����ֵ����10%
    private void Collection_Enemy_HpDown2()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.HealthRise*=0.9f;
        }
    }

    //�з�����ֵ����20%
    private void Collection_Enemy_HpDown3()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.HealthRise *= 0.8f;
        }
    }

    //�ҷ����������
    //�ҷ�����������10%
    private void Collection_Player_DefenseRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.1f;
        }
    }
    //�ҷ�����������25%
    private void Collection_Player_DefenseRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.25f;
        }
    }
    //�ҷ�����������50%
    private void Collection_Player_DefenseRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.5f;
        }
    }

    //�ҷ�����������100%
    private void Collection_Player_DefenseRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 2.0f;
        }
    }

    //�ҷ�������ֵ����50��
    private void Collection_Player_DefensePointRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense +=50f;
        }
    }
    //�ҷ�������ֵ����100��
    private void Collection_Player_DefensePointRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense += 100f;
        }
    }
    //�ҷ�������ֵ����250��
    private void Collection_Player_DefensePointRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense += 250f;
        }
    }
    //�ҷ�������ֵ����500��
    private void Collection_Player_DefensePointRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense += 500f;
        }
    }
    //�з����������
    //�з�����������10%
    private void Collection_Enemy_DefenseDown1()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.9f;
        }
    }
    //�з�����������20%
    private void Collection_Enemy_DefenseDown2()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.8f;
        }
    }
    //�з�����������30%
    private void Collection_Enemy_DefenseDown3()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.7f;
        }
    }
    //�з�����������50%
    private void Collection_Enemy_DefenseDown4()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.5f;
        }
    }
    //���������
    //�ҷ�����������20%
    private void Collection_Player_AttackRise1()
    {
        if (isGet)
        {
            isGet=false;
            PlayerInfo.attack *= 1.2f;
        }
    }
    //�ҷ�����������35%
    private void Collection_Player_AttackRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.35f;
        }
    }
    //�ҷ�����������50%
    private void Collection_Player_AttackRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.5f;
        }
    }
    //�ҷ�����������50��
    private void Collection_Player_AttackPointRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack +=50f;
        }
    }
    //�ҷ�����������100��
    private void Collection_Player_AttackPointRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack += 100f;
        }
    }
    //�ҷ�����������250��
    private void Collection_Player_AttackPointRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack += 250f;
        }
    }
    //�ҷ�����������500��
    private void Collection_Player_AttackPointRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack += 500f;
        }
    }
    //�з�����������10%
    private void Collection_Enemy_AttackDown1()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise*=0.9f;
        }
    }
    //�з�����������20%
    private void Collection_Enemy_AttackDown2()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise *= 0.8f;
        }
    }
    //�з�����������30%
    private void Collection_Enemy_AttackDown3()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise *= 0.7f;
        }
    }
    //�ҷ�ÿ��ظ�����ֵ10��
    private void Collection_Player_HpRiseWithTime1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += Time.deltaTime * 10;
        }
    }
    //�ҷ�ÿ��ظ�����ֵ25��
    private void Collection_Player_HpRiseWithTime2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += Time.deltaTime * 25;
        }
    }
    //�ҷ���������10%
    private void Collection_Player_MoveSpeedRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed*=1.1f;
        }
    }
    //�ҷ���������20%
    private void Collection_Player_MoveSpeedRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.2f;
        }
    }
    //�ҷ���������50%
    private void Collection_Player_MoveSpeedRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.5f;
        }
    }
    //�з����ٽ���10%
    private void Collection_Enemy_MoveSpeedDown1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.9f;
        }
    }
    //�з����ٽ���20%
    private void Collection_Enemy_MoveSpeedDown2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.8f;
        }
    }
    //�з����ٽ���30%
    private void Collection_Enemy_MoveSpeedDown3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.7f;
        }
    }
    //�ҷ���������10%
    private void Collection_Player_ReliefRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.relief *= 1.1f;
        }
    }
    //�ҷ���������15%
    private void Collection_Player_ReliefRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.relief *= 1.15f;
        }
    }

    //�ҷ���������20%
    private void Collection_Player_ReliefRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.relief *= 1.2f;
        }
    }
    //�ҷ�������������10%
    private void Collection_Player_HitRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attackHit *= 1.1f;
        }
    }
    //�ҷ�������������20%
    private void Collection_Player_HitRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attackHit *= 1.2f;
        }
    }
    //�ҷ�������������30%
    private void Collection_Player_HitRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attackHit *= 1.3f;
        }
    }
    //�ҷ���̾�������20%
    public void Collection_Player_SprintLengthRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.sprintLength *= 1.2f;
        }
    }
    //�ҷ���̾�������35%
    public void Collection_Player_SprintLengthRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.sprintLength *= 1.35f;
        }
    }
    //�ҷ���̾�������50%
    public void Collection_Player_SprintLengthRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.sprintLength *= 1.5f;
        }
    }
    //�ۺ���
    //����������25%������������25%
    public void Collection_Player_HpAttackRise()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.25f;
            PlayerInfo.attack *= 1.25f;
        }
    }
    //����������5%������������5%������������5%
    public void Collection_Player_HpDefenseAttackRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.05f;
            PlayerInfo.attack *= 1.05f;
            PlayerInfo.defense *= 1.05f;
        }
    }
    //����������10%������������10%������������10%
    public void Collection_Player_HpDefenseAttackRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.1f;
            PlayerInfo.attack *= 1.1f;
            PlayerInfo.defense *= 1.1f;
        }
    }
    //����������15%������������15%������������15%
    public void Collection_Player_HpDefenseAttackRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.15f;
            PlayerInfo.attack *= 1.15f;
            PlayerInfo.defense *= 1.15f;
        }
    }
    //����������15%����������15%
    public void Collection_Player_AttackMoveSpeedRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.15f;
            PlayerInfo.attack *= 1.15f;
        }
    }
    //����������25%����������5%
    public void Collection_Player_AttackMoveSpeedRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.25f;
            PlayerInfo.attack *= 1.05f;
        }
    }
    //�������������25%���з�����������25%
    public void Collection_Both_Defense()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.25f;
            GameManager.DefRise *= 0.75f;
        }
    }
    //������������15%���з����ٽ���15%
    public void Collection_Both_MoveSpeed()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.15f;
            GameManager.SpeedRise *= 0.85f;
        }
    }

    //������������25%������������50%������������25%
    public void Collection_Player_AttDown_SpeedDefenseUp1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 0.75f;
            PlayerInfo.speed *= 1.5f;
            PlayerInfo.defense *= 1.25f;
        }
    }
    //������������30%������������70%������������40%
    public void Collection_Player_AttDown_SpeedDefenseUp2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 0.7f;
            PlayerInfo.speed *= 1.7f;
            PlayerInfo.defense *= 1.4f;
        }
    }
    //�������������25%������������50%
    public void Collection_Player_DefenseDown_AttUp1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.5f;
            PlayerInfo.defense *= 0.75f;
        }
    }
    //�������������40%������������70%
    public void Collection_Player_DefenseDown_AttUp2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.7f;
            PlayerInfo.defense *= 0.6f;
        }
    }
    //�������ٽ���20%��������������50%������������20%
    public void Collection_Player_SpeedDown_AttDefenseUp1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.8f;
            PlayerInfo.attack *= 1.5f;
            PlayerInfo.defense *= 1.2f;
        }
    }
    //�������ٽ���30%��������������70%������������35%
    public void Collection_Player_SpeedDown_AttDefenseUp2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.7f;
            PlayerInfo.attack *= 1.7f;
            PlayerInfo.defense *= 1.35f;
        }
    }

    //������з�����������100%
    public void Collection_Both_AttUp()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise *= 2f;
            PlayerInfo.attack *= 2f;
        }
    }

    //������з���������100%
    public void Collection_Both_SpeedUp()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.SpeedRise *= 2f;
            PlayerInfo.speed *= 2f;
        }
    }
    //������������120%���з�����������50%
    public void Collection_Player_AttUp_Enemy_DefUp()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 1.5f;
            PlayerInfo.attack *= 1.2f;
        }
    }
    //��������������120%���з���������50%
    public void Collection_Player_HpUp_Enemy_SpeedUp()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.SpeedRise *= 1.5f;
            PlayerInfo.health *= 2.2f;
        }
    }

}
