using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NavigationManager
{
    private static int currentLevel = 0;
    private static List<string> levels = new List<string>
    {
        "EsperandoOSucesso",
        "TBF",
        "TBF",
        "TBF",
        "TBF"
    };

    public static int CurrentLevel => currentLevel;

    public static void NextLevel()
    {
        if (currentLevel < levels.Count - 1)
        {
            currentLevel++;
        }
    }

    public static string GetCurrentLevelName()
    {
        return levels[currentLevel];
    }

    public static bool IsLevelUnlocked(int levelIndex)
    {
        return levelIndex <= currentLevel;
    }
}