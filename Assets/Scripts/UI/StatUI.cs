using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StatUI : MonoBehaviour
{
    public RowUI rowUI;
    private List<RowUI> rows;
    public StatManager statManager;
    private void Start()
    {
        var stats = statManager.GetHighScores().ToArray();
        rows = new List<RowUI>();
        for (int i = 0; i < stats.Length; i++)
        {
            var row = Instantiate(rowUI, transform).GetComponent<RowUI>();
            row.player.color = stats[i].playerColor;
            row.player.text = stats[i].player;
            row.kills.text = stats[i].kills.ToString();
            rows.Add(row);
        }
    }
    private void Update()
    {
        var stats = statManager.GetHighScores().ToArray();
        for (int i = 0; i < stats.Length; i++)
        {
            rows[i].player.color = stats[i].playerColor;
            rows[i].player.text = stats[i].player;
            rows[i].kills.text = stats[i].kills.ToString();
        }
    }
}
