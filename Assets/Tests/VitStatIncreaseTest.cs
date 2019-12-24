using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class VitStatIncreaseTest
{
    [Test]
    public void VitStatIncreaseTestWhenStatUp()
    {
        var player = new PlayerStats();
        var stats = new WindowStats();
        int oldvit = PlayerStats.vitality;
        player.Start();
        PlayerStats.statspoints = 1;
        stats.upvit();
        Assert.Greater(PlayerStats.vitality, oldvit);
    }
}
