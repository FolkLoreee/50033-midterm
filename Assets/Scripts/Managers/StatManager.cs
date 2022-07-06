using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class StatManager : MonoBehaviour
{
    private List<Stat> stats;

    private void Awake()
    {
        stats = new List<Stat>();
        GameManager.OnTankDeath += IncreaseKill;
    }
    public IEnumerable<Stat> GetHighScores()
    {
        return stats.OrderByDescending(x => x.kills);
    }
    public void AddEntry(Stat stat)
    {
        stats.Add(stat);
    }

    public void IncreaseKill(TankHealth tankH)
    {
        var tankNumber = tankH.m_PlayerNumber;
        for (int i = 0; i < stats.Count; i++)
        {
            if (stats[i].player == "Player " + tankNumber.ToString())
            {
                stats[i].kills++;
            }
        }
    }

}
