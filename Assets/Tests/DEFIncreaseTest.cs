using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class DEFincreaseTest
{
    [Test]
    public void DEFincreaseWhenStatUp()
    {
        var player = new PlayerStats();
        var stats = new WindowStats();
        player.Start();
        float olddef = PlayerStats.DEF;
        PlayerStats.statspoints = 1;
        stats.updef();
        Assert.Greater(PlayerStats.HP, olddef);
    }
}