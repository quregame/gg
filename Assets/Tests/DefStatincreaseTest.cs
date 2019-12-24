using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class DefStatIncreaseTest
{
    [Test]
    public void DefStatIncreaseWhenStatUp()
    {
        var player = new PlayerStats();
        var stats = new WindowStats();
        int olddef = PlayerStats.defense;
        player.Start();
        PlayerStats.statspoints = 1;
        stats.updef();
        Assert.Greater(PlayerStats.defense, olddef);
    }
}
