using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.UI;

public class AliveTest
{
    [Test]
    public void AliveNewGame()
    {
        var player = new PlayerStats();
        PlayerStats.death = true;
        player.Start();
        Assert.False(PlayerStats.death);
    }
}
