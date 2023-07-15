using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCardToHand : MonoBehaviour
{
    public static AddCardToHand instance;
    [SerializeField] GameObject Card;

    private void Awake()
    {
        instance = this;

    }
    private void OnMouseDown()
    {
        AddCard(GameSettings.instance.activePlayer.hand);
    }

    public void AddCard(Hand Hand)
    {
        CardSettings settings = CardSettings.instance;
        CardSettings.Colors randomColor = (CardSettings.Colors)Random.Range(0, 4);
        Card = settings.GetRandomCard(randomColor);
        GameObject newCard = Instantiate(Card, Hand.transform);
        Hand.Cards.Add(newCard);
        Hand.AdjustSpacing();
        Hand.CardsInHand++;
        GameOptions.instance.EndTurn();
    }
}
