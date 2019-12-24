using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class DeathTest
{
    [Test]
    public void DeathWhenBigDamage()
    {
        var player = new PlayerStats();
        player.Start();
        PlayerStats.curHP = PlayerStats.curHP - 10000;
        player.Update();
        Assert.True(PlayerStats.death);
    }
}
