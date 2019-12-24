using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class DMGincreaseTest
{
    [Test]
    public void DMGincreaseWhenStatUp()
    {
        var player = new PlayerStats();
        var stats = new WindowStats();
        player.Start();
        float olddmg = PlayerStats.maxDMG;
        PlayerStats.statspoints = 1;
        stats.upsharp();
        Assert.Greater(PlayerStats.HP, olddmg);
    }
}
