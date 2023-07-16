using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOptions : MonoBehaviour
{
    public static GameOptions instance;
    public TurnOrder order;
    public enum TurnOrder
    {
        Default,
        Reverse
    };
    public void Awake()
    {
        instance = this;
    }
    public void EndTurn()
    {
        if (order == TurnOrder.Default)
        {
            if (GameSettings.instance.activePlayerNr < GameSettings.instance.AmountOfPlayers)
                GameSettings.instance.activePlayerNr++;
            else
            {
                GameSettings.instance.activePlayerNr = 1;
            }
        }
        else if (order == TurnOrder.Reverse)
        {
            if (GameSettings.instance.activePlayerNr > 1 && GameSettings.instance.activePlayerNr <= GameSettings.instance.AmountOfPlayers)
                GameSettings.instance.activePlayerNr--;
            else if(GameSettings.instance.activePlayerNr <= 1)
            {
                GameSettings.instance.activePlayerNr = 4;
            }
        }
    }
}
