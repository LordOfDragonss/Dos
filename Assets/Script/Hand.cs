using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public static Hand instance;
    public List<GameObject> Cards;
    public int StarterCards;
    public int CardsInHand = 0;
    public float spacingX = 0.5f;
    public float spacingY = -0.01f;
    public GameObject ActiveCard;
    public int cardsPerRow;

    private void Start()
    {
        for (int i = 0; i < StarterCards; i++)
        {
            AddCardToHand.instance.AddCard(this);
        }
    }
    public class CompareColor : IComparer<GameObject>
    {
        public int Compare(GameObject x, GameObject y)
        {
            Card xClass = x.GetComponent<Card>();
            Card yClass = y.GetComponent<Card>();

            return xClass.color.CompareTo(yClass.color);
        }
    }
    public void SortListOnColor()
    {
        Cards.Sort( new CompareColor());
    }
    public void AdjustSpacing()
    {
        SortListOnColor();
        int rowIndex = 0;
        int columnIndex = 0;

        for (int i = 0; i < Cards.Count; i++)
        {
            GameObject obj = Cards[i];
            //calculate the center of the cards
            float CenterOffsetX = (cardsPerRow - 1) * spacingX / 2f; ;
            float CenterOffsetY = rowIndex * spacingY / 2f;

            // Calculate position based on row and column index
            Vector3 offset = Quaternion.Euler(obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z) * new Vector3(columnIndex * spacingX - CenterOffsetX, 0f,  rowIndex * spacingY - CenterOffsetY);
            Vector3 position = transform.position
                + offset;

            // Set the position of the game object
            obj.transform.position = position;

            // Update row and column indices
            columnIndex++;

            if (columnIndex >= cardsPerRow)
            {
                columnIndex = 0;
                rowIndex++;
            }
        }
    }
}
