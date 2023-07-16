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
    public int WildCards = 2;
    public GameObject Draw4;
    public GameObject PickColor;

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
    public GameObject SkipRed;
    public GameObject ReverseRed;
    public GameObject Draw2Red;

    [Header("BlueCards")]
    public int blueCards;
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
    public GameObject SkipBlue;
    public GameObject ReverseBlue;
    public GameObject Draw2Blue;

    [Header("GreenCards")]
    public int greenCards;
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
    public GameObject SkipGreen;
    public GameObject ReverseGreen;
    public GameObject Draw2Green;

    [Header("YellowCards")]
    public int yellowCards;
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
    public GameObject SkipYellow;
    public GameObject ReverseYellow;
    public GameObject Draw2Yellow;

    [Header("CurrentCards")]
    public GameObject ActiveCard;

    public enum Colors
    {
        red,
        green,
        blue,
        yellow,
        any
    }

    public GameObject GetRandomCard(Colors color)
    {
        int randomNr = 0;
        if (color == Colors.red)
        {
            randomNr = Random.Range(0, redCards);
            ActiveCard = GetRedCardOnNumber(randomNr);
        }
        if (color == Colors.green)
        {
            randomNr = Random.Range(0, greenCards);
            ActiveCard = GetGreenCardOnNumber(randomNr);
        }
        if (color == Colors.blue)
        {
            randomNr = Random.Range(0, blueCards);
            ActiveCard = GetBlueCardOnNumber(randomNr);
        }

        if (color == Colors.yellow)
        {
            randomNr = Random.Range(0, yellowCards);
            ActiveCard = GetYellowCardOnNumber(randomNr);
        }
        if (color == Colors.any)
        {
            randomNr = Random.Range(0, WildCards);
            ActiveCard = GetWildCard(randomNr);
        }
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
            case 10:
                return SkipRed;
            case 11:
                return ReverseRed;
            case 12:
                return Draw2Red;
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
            case 10:
                return SkipBlue;
            case 11:
                return ReverseBlue;
            case 12:
                return Draw2Blue;
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
            case 10:
                return SkipGreen;
            case 11:
                return ReverseGreen;
            case 12:
                return Draw2Green;
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
            case 10:
                return SkipYellow;
            case 11:
                return ReverseYellow;
            case 12:
                return Draw2Yellow;
            default:
                return null;
        }
    }

    public GameObject GetWildCard(int nr)
    {
        switch (nr)
        {
            case 0:
                return PickColor;
            case 1:
                return Draw4;
            default:
                return null;
        }
    }
}
