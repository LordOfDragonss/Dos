using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOnSpot : MonoBehaviour
{
    [SerializeField] GameObject ObjectToPlace;
    [SerializeField] GameObject previousobject;

    //public void checkBorders()
    //{
    //    Spot.gameObject.transform.position;
    //}
    private void OnMouseDown()
    {
        if(previousobject != null)
            Destroy(previousobject);
        CardSettings settings = CardSettings.instance;
        CardSettings.Colors randomColor = (CardSettings.Colors)Random.Range(0, 4);
        ObjectToPlace = settings.GetRandomCard(randomColor);
        previousobject = Instantiate(ObjectToPlace, transform);

    }
}
