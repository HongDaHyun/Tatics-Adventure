using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : Singleton<GameManager>
{
    [Title("변수 (저장O)")]
    public PlayerType playerType;
    public int money;

    [Title("변수 (저장X)")]
    public Stage stage;
    public Level level;

    [Title("수치 변수 (조정 가능)")]
    public int[] coinUnit;
    public int weaponPerDmg;
    public int maxPortion;
    public int[] luck;

    public void EarnMoney(int coin)
    {
        money += coin;

        UIManager.Instance.MoneyTxt(money);
    }
}

public enum Stage { Grass = 0, Cave, Swarm, Forest }
public enum Level { Easy = 0, Normal, Hard }
public enum Tier { Common = 0, Rare, Epic, Legend }