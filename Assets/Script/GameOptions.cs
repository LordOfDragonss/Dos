using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOptions : MonoBehaviour
{
    public static GameOptions instance;
    public void Awake()
    {
        instance = this;
    }
    public void EndTurn()
    {
        if (GameSettings.instance.activePlayerNr < GameSettings.instance.AmountOfPlayers)
            GameSettings.instance.activePlayerNr++;
        else
        {
            GameSettings.instance.activePlayerNr = 1;
        }
    }
}
