using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardData", menuName = "My Card Data")]   
public class CardData : ScriptableObject
{
    //public GameObject cardObject;
    public string cardName;
    public int cardIDNumber;
    public int cardSuit;
    public string cardSuitName;
    public int straightNumber;
    public GameObject cardObject;
}
