using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildCardActions
{
    public void Draw2()
    {
        PlayerSettings victim = GetVictim();
        AddCardToHand.instance.AddCard(victim.hand);
        AddCardToHand.instance.AddCard(victim.hand);
        GameOptions.instance.EndTurn();
    }
    public void Draw4()
    {
        PickColor();
        PlayerSettings victim = GetVictim();
        AddCardToHand.instance.AddCard(victim.hand);
        AddCardToHand.instance.AddCard(victim.hand);
        AddCardToHand.instance.AddCard(victim.hand);
        AddCardToHand.instance.AddCard(victim.hand);
    }

    public PlayerSettings GetVictim()
    {
        PlayerSettings victim = null;
        if (GameOptions.instance.order == GameOptions.TurnOrder.Default)
        {
            if (GameSettings.instance.activePlayerNr > 1 && GameSettings.instance.activePlayerNr < 4)
            {
                victim = GameSettings.instance.Players.Find(x => x.PlayerNr == GameSettings.instance.activePlayerNr + 1);
            }
            else if (GameSettings.instance.activePlayerNr == 4)
            {
                victim = GameSettings.instance.Players.Find(x => x.PlayerNr == 1);

            }
        }
        else if (GameOptions.instance.order == GameOptions.TurnOrder.Reverse)
        {
            if (GameSettings.instance.activePlayerNr > 1 && GameSettings.instance.activePlayerNr < 4)
            {
                victim = GameSettings.instance.Players.Find(x => x.PlayerNr == GameSettings.instance.activePlayerNr - 1);
            }
            else if (GameSettings.instance.activePlayerNr == 1)
            {
                victim = GameSettings.instance.Players.Find(x => x.PlayerNr == 4);

            }
        }
        return victim;
    }

    public void PickColor()
    {
        GameSettings.instance.activePlayer.isSelectingColor = true;
    }

    public void SkipTurn()
    {
        GameOptions.instance.EndTurn();
    }
    public void Reverse()
    {

        if (GameOptions.instance.order == GameOptions.TurnOrder.Default)
        {
            Debug.Log("REVERSING!");
            GameOptions.instance.order = GameOptions.TurnOrder.Reverse;
        }
        else if (GameOptions.instance.order == GameOptions.TurnOrder.Reverse)
        {
            Debug.Log("back to normal!");
            GameOptions.instance.order = GameOptions.TurnOrder.Default;
        }
    }


}
