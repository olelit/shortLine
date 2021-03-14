using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveLoadScore
{

    const string SaveName = "short_line_save_data";
    public static void SaveIfBiggestThenCurrent(int value)
    {
        int currentScore = Load();
        if(currentScore < value)
            PlayerPrefs.SetInt(SaveName, value);
    }

    public static int Load() => PlayerPrefs.GetInt(SaveName, 0);
}
