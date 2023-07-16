using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    [SerializeField] GameObject redCard;
    [SerializeField] GameObject greenCard;
    [SerializeField] GameObject blueCard;
    [SerializeField] GameObject yellowCard;
    private void Update()
    {
        if (GameSettings.instance.activePlayer.isSelectingColor)
        {
            canvas.enabled = true;
        }
        else
        {
            canvas.enabled = false;
        }
    }

    public void PickRed()
    {
        Destroy(CardStack.instance.topCard);
        CardStack.instance.topCard = Instantiate(redCard, CardStack.instance.gameObject.transform );
        CardStack.instance.topCard.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f / 10, transform.position.z);
        //CardStack.instance.topCard.GetComponent<Card>().color = CardSettings.Colors.red;
        GameSettings.instance.activePlayer.isSelectingColor = false;
        GameOptions.instance.EndTurn();
    }
    public void PickBlue()
    {
        Destroy(CardStack.instance.topCard);
        CardStack.instance.topCard = Instantiate(blueCard, CardStack.instance.gameObject.transform);
        CardStack.instance.topCard.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f / 10, transform.position.z);
        //CardStack.instance.topCard.GetComponent<Card>().color = CardSettings.Colors.blue;
        GameSettings.instance.activePlayer.isSelectingColor = false;
        GameOptions.instance.EndTurn();
    }
    public void PickGreen()
    {
        Destroy(CardStack.instance.topCard);
        CardStack.instance.topCard = Instantiate(greenCard, CardStack.instance.gameObject.transform);
        CardStack.instance.topCard.transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f / 10, transform.position.z);
        //CardStack.instance.topCard.GetComponent<Card>().color = CardSettings.Colors.green;
        GameSettings.instance.activePlayer.isSelectingColor = false;
        GameOptions.instance.EndTurn();
    }
    public void PickYellow()
    {
        Destroy(CardStack.instance.topCard);
        CardStack.instance.topCard = Instantiate(yellowCard, CardStack.instance.gameObject.transform);
        CardStack.instance.topCard.transform.position = new Vector3(CardStack.instance.gameObject.transform.position.x, CardStack.instance.gameObject.transform.position.y + 0.1f / 10, CardStack.instance.gameObject.transform.position.z);
        //CardStack.instance.topCard.GetComponent<Card>().color = CardSettings.Colors.yellow;
        GameSettings.instance.activePlayer.isSelectingColor = false;
        GameOptions.instance.EndTurn();

    }
}
