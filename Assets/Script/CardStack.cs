using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStack : MonoBehaviour
{
    public WildCardActions actions = new WildCardActions();
    [SerializeField] public GameObject topCard;
    GameSettings game;
    [SerializeField] private float yOffset;
    public static CardStack instance;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        game = GameSettings.instance;
        CardSettings.Colors randomColor = (CardSettings.Colors)Random.Range(0, 4);
        GameObject randomCard = CardSettings.instance.GetRandomCard(randomColor);
        topCard = Instantiate(randomCard, transform);
        topCard.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f / 10, transform.position.z);
        Destroy(topCard.GetComponent<CardSelection>());
        Destroy(topCard.GetComponent<BoxCollider>());
    }

    private void OnMouseDown()
    {
        if (!GameSettings.instance.activePlayer.isSelectingColor)
        {
            Card CardtopCard = topCard.GetComponent<Card>();
            Card CardActiveCard = game.activePlayer.hand.ActiveCard.GetComponent<Card>();
            if (
                CardtopCard.color == CardActiveCard.color ||
                CardtopCard.Number == CardActiveCard.Number ||
                CardActiveCard.color == CardSettings.Colors.any ||
                CardtopCard.Number == -1
                )
            {
                Destroy(topCard);
                topCard = Instantiate(game.activePlayer.hand.ActiveCard, transform);
                topCard.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f / 10, transform.position.z);
                Destroy(topCard.GetComponent<BoxCollider>());
                Destroy(topCard.GetComponent<CardSelection>());
                game.activePlayer.hand.Cards.Remove(game.activePlayer.hand.ActiveCard);
                Destroy(game.activePlayer.hand.ActiveCard);
                game.activePlayer.hand.AdjustSpacing();
                game.activePlayer.hand.CardsInHand--;
                if (CardActiveCard.isWild)
                {
                    Debug.Log("wildin time");
                    DoWildAction(CardActiveCard.Number);
                }
                if (!GameSettings.instance.activePlayer.isSelectingColor)
                    GameOptions.instance.EndTurn();
            }
            else
            {
                Debug.Log("card incompatible");
            }
        }
    }
    private void DoWildAction(int number)
    {
        Debug.Log("wildAction");
        switch (number)
        {
            case 0:
                actions.PickColor();
                break;
            case 1:
                actions.Draw4();
                break;
            case 10:
                actions.SkipTurn();
                break;
            case 11:
                actions.Reverse();
                break;
            case 12:
                actions.Draw2();
                break;
        }
    }
}
