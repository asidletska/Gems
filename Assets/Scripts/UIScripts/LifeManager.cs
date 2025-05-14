using System;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;
    public float timeToNextLife = 1800f;

    private DateTime lastExitTime;
    private string lastExitKey = "LastExitTime";
    private string liveskey = "CurrentLives";

    private void Start()
    {
        currentLives = PlayerPrefs.GetInt(liveskey, maxLives);
        if (PlayerPrefs.HasKey(lastExitKey))
        {
            lastExitTime = DateTime.Parse(PlayerPrefs.GetString(lastExitKey));
            TimeSpan timeAway = DateTime.Now - lastExitTime;
            int livesToAdd = Mathf.FloorToInt((float)timeAway.TotalSeconds / timeToNextLife);
            currentLives = Mathf.Min(currentLives + livesToAdd, maxLives);
        }
        InvokeRepeating(nameof(AddLifeOverTime), timeToNextLife, timeToNextLife);
    }
    private void OnApplicationQuit()
    {
        
    }
    private void AddLifeOverTime()
    {
        if (currentLives < maxLives)
        {
            currentLives++;
            PlayerPrefs.SetInt(liveskey, currentLives);
        }
    }
}
