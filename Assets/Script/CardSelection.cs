using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSelection : MonoBehaviour
{
    private void OnMouseDown()
    {  
            GameSettings.instance.activePlayer.hand.ActiveCard = this.gameObject;
    }
}
