using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Preference
{
    private static int currentPlanet = 0;
    private static float highScore = 0;
    public static int CurrentPlanet
    {
        get
        {
            return currentPlanet;
        }
        set
        {
            currentPlanet = value;
        }
    }
    public static float HighScore
    {
        get
        {
            return highScore;
        }
        set
        {
            highScore = value;
        }
    }

}
