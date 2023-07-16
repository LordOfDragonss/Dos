using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStack : MonoBehaviour
{
    [SerializeField] private GameObject topCard;
    GameSettings game;
    [SerializeField] private float yOffset;
    private void Start()
    {
        game = GameSettings.instance;
        CardSettings.Colors randomColor = (CardSettings.Colors)Random.Range(0, 4);
        GameObject randomCard = CardSettings.instance.GetRandomCard(randomColor);
        topCard = Instantiate(randomCard, transform);
        topCard.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f/10, transform.position.z);
        Destroy(topCard.GetComponent<CardSelection>());
        Destroy(topCard.GetComponent<BoxCollider>());
    }

    private void OnMouseDown()
    {
        
        Card CardtopCard = topCard.GetComponent<Card>();
        Card CardActiveCard = game.activePlayer.hand.ActiveCard.GetComponent<Card>();
        if (CardtopCard.color == CardActiveCard.color || CardtopCard.Number == CardActiveCard.Number)
        {
            Destroy(topCard);
            topCard = Instantiate(game.activePlayer.hand.ActiveCard, transform);
            topCard.transform.position = new Vector3(transform.position.x, transform.position.y+0.1f/10, transform.position.z);
            Destroy(topCard.GetComponent<BoxCollider>());
            Destroy(topCard.GetComponent<CardSelection>());
            game.activePlayer.hand.Cards.Remove(game.activePlayer.hand.ActiveCard);
            Destroy(game.activePlayer.hand.ActiveCard);
            game.activePlayer.hand.AdjustSpacing();
            game.activePlayer.hand.CardsInHand--;
            GameOptions.instance.EndTurn();
        }
        else
        {
            Debug.Log("card incompatible");
        }
    }
}
