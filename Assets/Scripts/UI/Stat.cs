using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat
{
    public string player;
    public float kills;
    public Color playerColor;

    public Stat(string player, int kills, Color playerColor)
    {
        this.player = player;
        this.kills = kills;
        this.playerColor = playerColor;
    }
}