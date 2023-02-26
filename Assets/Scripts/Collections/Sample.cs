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
    //我方生命力相关
    //HP增加10%
    private void Collection_Player_HpRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.1f;
        }
    }
    //HP增加20%
    private void Collection_Player_HpRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.2f;
        }
    }

    //HP增加50%
    private void Collection_Player_HpRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.5f;
        }
    }

    //HP值增加100点
    private void Collection_Player_HpPointRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 100f;
        }
    }

    //HP增加500点
    private void Collection_Player_HpPointRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 500f;
        }
    }

    //HP增加1000点
    private void Collection_Player_HpPointRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 1000f;
        }
    }

    //HP增加2000点
    private void Collection_Player_HpPointRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += 2000f;
        }
    }

    //敌方生命值相关
    //敌方生命值降低5%
    private void Collection_Enemy_HpDown1()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.HealthRise *= 0.95f;
        }
    }

    //敌方生命值降低10%
    private void Collection_Enemy_HpDown2()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.HealthRise*=0.9f;
        }
    }

    //敌方生命值降低20%
    private void Collection_Enemy_HpDown3()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.HealthRise *= 0.8f;
        }
    }

    //我方防御力相关
    //我方防御力增加10%
    private void Collection_Player_DefenseRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.1f;
        }
    }
    //我方防御力增加25%
    private void Collection_Player_DefenseRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.25f;
        }
    }
    //我方防御力增加50%
    private void Collection_Player_DefenseRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.5f;
        }
    }

    //我方防御力增加100%
    private void Collection_Player_DefenseRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 2.0f;
        }
    }

    //我方防御力值增加50点
    private void Collection_Player_DefensePointRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense +=50f;
        }
    }
    //我方防御力值增加100点
    private void Collection_Player_DefensePointRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense += 100f;
        }
    }
    //我方防御力值增加250点
    private void Collection_Player_DefensePointRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense += 250f;
        }
    }
    //我方防御力值增加500点
    private void Collection_Player_DefensePointRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense += 500f;
        }
    }
    //敌方防御力相关
    //敌方防御力降低10%
    private void Collection_Enemy_DefenseDown1()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.9f;
        }
    }
    //敌方防御力降低20%
    private void Collection_Enemy_DefenseDown2()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.8f;
        }
    }
    //敌方防御力降低30%
    private void Collection_Enemy_DefenseDown3()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.7f;
        }
    }
    //敌方防御力降低50%
    private void Collection_Enemy_DefenseDown4()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 0.5f;
        }
    }
    //攻击力相关
    //我方攻击力增加20%
    private void Collection_Player_AttackRise1()
    {
        if (isGet)
        {
            isGet=false;
            PlayerInfo.attack *= 1.2f;
        }
    }
    //我方攻击力增加35%
    private void Collection_Player_AttackRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.35f;
        }
    }
    //我方攻击力增加50%
    private void Collection_Player_AttackRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.5f;
        }
    }
    //我方攻击力增加50点
    private void Collection_Player_AttackPointRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack +=50f;
        }
    }
    //我方攻击力增加100点
    private void Collection_Player_AttackPointRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack += 100f;
        }
    }
    //我方攻击力增加250点
    private void Collection_Player_AttackPointRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack += 250f;
        }
    }
    //我方攻击力增加500点
    private void Collection_Player_AttackPointRise4()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack += 500f;
        }
    }
    //敌方攻击力降低10%
    private void Collection_Enemy_AttackDown1()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise*=0.9f;
        }
    }
    //敌方攻击力降低20%
    private void Collection_Enemy_AttackDown2()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise *= 0.8f;
        }
    }
    //敌方攻击力降低30%
    private void Collection_Enemy_AttackDown3()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise *= 0.7f;
        }
    }
    //我方每秒回复生命值10点
    private void Collection_Player_HpRiseWithTime1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += Time.deltaTime * 10;
        }
    }
    //我方每秒回复生命值25点
    private void Collection_Player_HpRiseWithTime2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health += Time.deltaTime * 25;
        }
    }
    //我方移速增加10%
    private void Collection_Player_MoveSpeedRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed*=1.1f;
        }
    }
    //我方移速增加20%
    private void Collection_Player_MoveSpeedRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.2f;
        }
    }
    //我方移速增加50%
    private void Collection_Player_MoveSpeedRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.5f;
        }
    }
    //敌方移速降低10%
    private void Collection_Enemy_MoveSpeedDown1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.9f;
        }
    }
    //敌方移速降低20%
    private void Collection_Enemy_MoveSpeedDown2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.8f;
        }
    }
    //敌方移速降低30%
    private void Collection_Enemy_MoveSpeedDown3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 0.7f;
        }
    }
    //我方闪避增加10%
    private void Collection_Player_ReliefRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.relief *= 1.1f;
        }
    }
    //我方闪避增加15%
    private void Collection_Player_ReliefRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.relief *= 1.15f;
        }
    }

    //我方闪避增加20%
    private void Collection_Player_ReliefRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.relief *= 1.2f;
        }
    }
    //我方击退力度提升10%
    private void Collection_Player_HitRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attackHit *= 1.1f;
        }
    }
    //我方击退力度提升20%
    private void Collection_Player_HitRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attackHit *= 1.2f;
        }
    }
    //我方击退力度提升30%
    private void Collection_Player_HitRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attackHit *= 1.3f;
        }
    }
    //我方冲刺距离增加20%
    public void Collection_Player_SprintLengthRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.sprintLength *= 1.2f;
        }
    }
    //我方冲刺距离增加35%
    public void Collection_Player_SprintLengthRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.sprintLength *= 1.35f;
        }
    }
    //我方冲刺距离增加50%
    public void Collection_Player_SprintLengthRise3()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.sprintLength *= 1.5f;
        }
    }
    //综合类
    //生命力提升25%，攻击力提升25%
    public void Collection_Player_HpAttackRise()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.health *= 1.25f;
            PlayerInfo.attack *= 1.25f;
        }
    }
    //生命力提升5%，防御力提升5%，攻击力提升5%
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
    //生命力提升10%，防御力提升10%，攻击力提升10%
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
    //生命力提升15%，防御力提升15%，攻击力提升15%
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
    //攻击力提升15%，移速提升15%
    public void Collection_Player_AttackMoveSpeedRise1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.15f;
            PlayerInfo.attack *= 1.15f;
        }
    }
    //攻击力提升25%，移速提升5%
    public void Collection_Player_AttackMoveSpeedRise2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.25f;
            PlayerInfo.attack *= 1.05f;
        }
    }
    //自身防御力增加25%，敌方防御力降低25%
    public void Collection_Both_Defense()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.defense *= 1.25f;
            GameManager.DefRise *= 0.75f;
        }
    }
    //自身移速增加15%，敌方移速降低15%
    public void Collection_Both_MoveSpeed()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.speed *= 1.15f;
            GameManager.SpeedRise *= 0.85f;
        }
    }

    //自身攻击力降低25%，但移速提升50%，防御力提升25%
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
    //自身攻击力降低30%，但移速提升70%，防御力提升40%
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
    //自身防御力降低25%，攻击力提升50%
    public void Collection_Player_DefenseDown_AttUp1()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.5f;
            PlayerInfo.defense *= 0.75f;
        }
    }
    //自身防御力降低40%，攻击力提升70%
    public void Collection_Player_DefenseDown_AttUp2()
    {
        if (isGet)
        {
            isGet = false;
            PlayerInfo.attack *= 1.7f;
            PlayerInfo.defense *= 0.6f;
        }
    }
    //自身移速降低20%，但攻击力提升50%，防御力提升20%
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
    //自身移速降低30%，但攻击力提升70%，防御力提升35%
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

    //自身与敌方攻击力提升100%
    public void Collection_Both_AttUp()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.AttRise *= 2f;
            PlayerInfo.attack *= 2f;
        }
    }

    //自身与敌方移速提升100%
    public void Collection_Both_SpeedUp()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.SpeedRise *= 2f;
            PlayerInfo.speed *= 2f;
        }
    }
    //自身攻击力提升120%，敌方防御力提升50%
    public void Collection_Player_AttUp_Enemy_DefUp()
    {
        if (isGet)
        {
            isGet = false;
            GameManager.DefRise *= 1.5f;
            PlayerInfo.attack *= 1.2f;
        }
    }
    //自身生命力提升120%，敌方移速提升50%
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
