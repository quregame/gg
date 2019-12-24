using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class HPincreaseTest
{
    [Test]
    public void HPincreaseWhenStatUp()
    {
        var player = new PlayerStats();
        var stats = new WindowStats();
        player.Start();
        float oldhp = PlayerStats.HP;
        PlayerStats.statspoints = 1;
        stats.upvit();
        Assert.Greater(PlayerStats.HP, oldhp);
    }
}
