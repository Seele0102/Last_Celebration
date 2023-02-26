using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int GameLevel;
    public static float HealthRise=1,DefRise,AttRise,SpeedRise;
    private void Start()
    {
        HealthRise = 1;
        DefRise=1;
        AttRise=1;
        SpeedRise=1;
        GameLevel = 0;
    }
    private void Update()
    {
        switch (GameLevel)
        {
            case 0:
                HealthRise=DefRise=AttRise=1;
                break;
            case 1:
                HealthRise = DefRise = AttRise = 1.2f;
                break;
            case 2:
                HealthRise = DefRise = AttRise = 1.5f;
                break;
            case 3:
                HealthRise = DefRise = AttRise = 1.8f;
                break;
            case 4:
                HealthRise = DefRise = AttRise = 2.2f;
                break;
        }
    }
}
