using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class NewTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void AchievementUnlocked_WhenPlayTimeOverFifteenHours()
    {
        var playerData = ScriptableObject.CreateInstance<PlayerDatas>();
        playerData.PlayTime = 10; // Simulate play time under fifteen hours
        var achievementManager = new AchievementManager();
        achievementManager.PlayerDatas = playerData;
        achievementManager.Lock = new GameObject().AddComponent<Image>(); // Simulate Lock Image

        // Act
        achievementManager.Start();

        // Assert
        Assert.IsTrue(achievementManager.Lock.gameObject.activeSelf, "Lock should be activated when play time is under fifteen hours.");
    }

    
    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}

[CreateAssetMenu(fileName = "PlayerDatas", menuName = "ScriptableObjects/PlayerDatas", order = 1)]
public class PlayerDatas : ScriptableObject
{
    public int PlayTime { get; set; }
}


internal class AchievementManager
{
    public AchievementManager()
    {
    }

    public PlayerDatas PlayerDatas { get; internal set; }
    public Image Lock { get; internal set; }

    internal void Start()
    {
        throw new NotImplementedException();
    }
}