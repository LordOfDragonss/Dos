using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public static GameSettings instance;
    public int AmountOfPlayers;
    public List<PlayerSettings> Players;
    public PlayerSettings activePlayer;
    public int activePlayerNr;
    public CardStack cardStack;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        activePlayer = Players.Find(x=>x.PlayerNr == activePlayerNr);
    }
}
