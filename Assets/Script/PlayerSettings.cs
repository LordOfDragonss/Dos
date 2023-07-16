using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    public int PlayerNr;
    public Hand hand;
    public bool hasUno;
    public bool isSelectingColor;

    [SerializeField] GameObject unoText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasUno)
        {
            unoText.SetActive(true);
        }
        else if (!hasUno)
        {
            unoText.SetActive(false);
        }
    }
}
