using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class SharpStatIncreaseTest
{
    [Test]
    public void SharpincreaseWhenStatUp()
    {
        var player = new PlayerStats();
        var stats = new WindowStats();
        int oldsharp = PlayerStats.sharpness;
        player.Start();
        PlayerStats.statspoints = 1;
        stats.upsharp();
        Assert.Greater(PlayerStats.sharpness, oldsharp);
    }
}
