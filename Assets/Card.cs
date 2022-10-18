using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card 
{
    public string cardName;
    public int cardIDNumber;
    public int cardSuit;
    public string cardSuitName;
    public int straightNumber;
    public GameObject gameObject;
   

    public Card (string name, int iDNumber, int suit,string suitName, int straightNum, GameObject gameObj = null)
    {
        this.cardName = name;
        this.cardIDNumber = iDNumber;
        this.cardSuit = suit;
        this.cardSuitName = suitName;
        this.straightNumber = straightNum;
        this.gameObject = gameObj;
    }
}
