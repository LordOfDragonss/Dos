using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSettings : MonoBehaviour
{
    public static CardSettings instance;
    public void Awake()
    {
        instance = this;
    }
    
    [Header("RedCards")]
    public int redCards;
    public GameObject Red0;
    public GameObject Red1;
    public GameObject Red2;
    public GameObject Red3;
    public GameObject Red4;
    public GameObject Red5;
    public GameObject Red6;
    public GameObject Red7;
    public GameObject Red8;
    public GameObject Red9;

    [Header("BlueCards")]
    public GameObject Blue0;
    public GameObject Blue1;
    public GameObject Blue2;
    public GameObject Blue3;
    public GameObject Blue4;
    public GameObject Blue5;
    public GameObject Blue6;
    public GameObject Blue7;
    public GameObject Blue8;
    public GameObject Blue9;

    [Header("GreenCards")]
    public GameObject Green0;
    public GameObject Green1;
    public GameObject Green2;
    public GameObject Green3;
    public GameObject Green4;
    public GameObject Green5;
    public GameObject Green6;
    public GameObject Green7;
    public GameObject Green8;
    public GameObject Green9;

    [Header("YellowCards")]
    public GameObject Yellow0;
    public GameObject Yellow1;
    public GameObject Yellow2;
    public GameObject Yellow3;
    public GameObject Yellow4;
    public GameObject Yellow5;
    public GameObject Yellow6;
    public GameObject Yellow7;
    public GameObject Yellow8;
    public GameObject Yellow9;

    [Header("CurrentCards")]
    public GameObject ActiveCard;

    public enum Colors
    {
        red,
        green,
        blue,
        yellow
    }

    public GameObject GetRandomCard(Colors color)
    {
        int randomNr = Random.Range(0, redCards);
        if (color == Colors.red)
            ActiveCard = GetRedCardOnNumber(randomNr);
        if (color == Colors.green)
            ActiveCard = GetGreenCardOnNumber(randomNr);
        if (color == Colors.blue)
            ActiveCard = GetBlueCardOnNumber(randomNr);
        if (color == Colors.yellow)
            ActiveCard = GetYellowCardOnNumber(randomNr);
        return ActiveCard;
    }

    public GameObject GetRedCardOnNumber(int nr)
    {
        switch (nr)
        {
            case 0:
                return Red0;
            case 1:
                return Red1;
            case 2:
                return Red2;
            case 3:
                return Red3;
            case 4:
                return Red4;
            case 5:
                return Red5;
            case 6:
                return Red6;
            case 7:
                return Red7;
            case 8:
                return Red8;
            case 9:
                return Red9;
            default:
                return null;
        }
    }

    public GameObject GetBlueCardOnNumber(int nr)
    {
        switch (nr)
        {
            case 0:
                return Blue0;
            case 1:
                return Blue1;
            case 2:
                return Blue2;
            case 3:
                return Blue3;
            case 4:
                return Blue4;
            case 5:
                return Blue5;
            case 6:
                return Blue6;
            case 7:
                return Blue7;
            case 8:
                return Blue8;
            case 9:
                return Blue9;
            default:
                return null;
        }
    }

    public GameObject GetGreenCardOnNumber(int nr)
    {
        switch (nr)
        {
            case 0:
                return Green0;
            case 1:
                return Green1;
            case 2:
                return Green2;
            case 3:
                return Green3;
            case 4:
                return Green4;
            case 5:
                return Green5;
            case 6:
                return Green6;
            case 7:
                return Green7;
            case 8:
                return Green8;
            case 9:
                return Green9;
            default:
                return null;
        }
    }

    public GameObject GetYellowCardOnNumber(int nr)
    {
        switch (nr)
        {
            case 0:
                return Yellow0;
            case 1:
                return Yellow1;
            case 2:
                return Yellow2;
            case 3:
                return Yellow3;
            case 4:
                return Yellow4;
            case 5:
                return Yellow5;
            case 6:
                return Yellow6;
            case 7:
                return Yellow7;
            case 8:
                return Yellow8;
            case 9:
                return Yellow9;
            default:
                return null;
        }
    }
}
