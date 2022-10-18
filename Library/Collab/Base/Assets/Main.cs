using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Main : MonoBehaviour
{
    public List<Card> cardList = new List<Card>()
    {
        //1st-name, 2nd-cardNumber, 3rd-Suit, 4th-straight, 5th-pairNumber
        new Card("ace",  /*cardnumber>*/0, /*suit>*/ 1,  /*str8>*/1,   /*pair>*/ 0),
        new Card("two",  /*cardnumber>*/1, /*suit>*/ 1,  /*str8>*/2,   /*pair>*/ 0),
        new Card("three",/*cardnumber>*/2, /*suit>*/ 1,  /*str8>*/3,   /*pair>*/ 0),
        new Card("four", /*cardnumber>*/3, /*suit>*/ 1,  /*str8>*/4,   /*pair>*/ 0),
        new Card("five", /*cardnumber>*/4, /*suit>*/ 1,  /*str8>*/5,   /*pair>*/ 0),
        new Card("six",  /*cardnumber>*/5, /*suit>*/ 1,  /*str8>*/6,   /*pair>*/ 0),
        new Card("seven",/*cardnumber>*/6, /*suit>*/ 1,  /*str8>*/7,   /*pair>*/ 0),
        new Card("eight",/*cardnumber>*/7, /*suit>*/ 1,  /*str8>*/8,    /*pair>*/0),
        new Card("nine", /*cardnumber>*/8, /*suit>*/ 1,  /*str8>*/9,    /*pair>*/0),
        new Card("ten",  /*cardnumber>*/9, /*suit>*/ 1,  /*str8>*/10,   /*pair>*/0),
        new Card("jack", /*cardnumber>*/10, /*suit>*/1,  /*str8>*/11,   /*pair>*/0),
        new Card("queen",/*cardnumber>*/11, /*suit>*/1,  /*str8>*/12,   /*pair>*/0),
        new Card("king", /*cardnumber>*/12, /*suit>*/1,  /*str8>*/13,   /*pair>*/0),

        new Card("ace",  /*cardnumber>*/13, /*suit>*/2, /*str8>*/ 1,    /*pair>*/0),
        new Card("two",  /*cardnumber>*/14,/*suit>*/ 2, /*str8>*/ 2,    /*pair>*/0),
        new Card("three",/*cardnumber>*/15,/*suit>*/ 2, /*str8>*/ 3,    /*pair>*/0),
        new Card("four", /*cardnumber>*/16,/*suit>*/ 2, /*str8>*/ 4,    /*pair>*/0),
        new Card("five", /*cardnumber>*/17,/*suit>*/ 2, /*str8>*/ 5,    /*pair>*/0),
        new Card("six",  /*cardnumber>*/18,/*suit>*/ 2, /*str8>*/ 6,    /*pair>*/0),
        new Card("seven",/*cardnumber>*/19,/*suit>*/ 2, /*str8>*/ 7,    /*pair>*/0),
        new Card("eight",/*cardnumber>*/20,/*suit>*/ 2, /*str8>*/ 8,    /*pair>*/0),
        new Card("nine", /*cardnumber>*/21,/*suit>*/ 2, /*str8>*/ 9,    /*pair>*/0),
        new Card("ten",  /*cardnumber>*/22,/*suit>*/ 2, /*str8>*/ 10,   /*pair>*/0),
        new Card("jack", /*cardnumber>*/23,/*suit>*/ 2, /*str8>*/ 11,   /*pair>*/0),
        new Card("queen",/*cardnumber>*/24,/*suit>*/ 2, /*str8>*/ 12,   /*pair>*/0),
        new Card("king", /*cardnumber>*/25,/*suit>*/ 2, /*str8>*/ 13,   /*pair>*/0),

        new Card("ace",  /*cardnumber>*/26,/*suit>*/ 3, /*str8>*/ 1,    /*pair>*/0),
        new Card("two",  /*cardnumber>*/27, /*suit>*/3, /*str8>*/ 2,    /*pair>*/0),
        new Card("three",/*cardnumber>*/28,/*suit>*/ 3, /*str8>*/ 3,    /*pair>*/0),
        new Card("four", /*cardnumber>*/29,/*suit>*/ 3, /*str8>*/ 4,    /*pair>*/0),
        new Card("five", /*cardnumber>*/30,/*suit>*/ 3, /*str8>*/ 5,    /*pair>*/0),
        new Card("six",  /*cardnumber>*/31,/*suit>*/ 3, /*str8>*/ 6,    /*pair>*/0),
        new Card("seven",/*cardnumber>*/32,/*suit>*/ 3, /*str8>*/ 7,    /*pair>*/0),
        new Card("eight",/*cardnumber>*/33,/*suit>*/ 3, /*str8>*/ 8,    /*pair>*/0),
        new Card("nine", /*cardnumber>*/34,/*suit>*/ 3, /*str8>*/ 9,    /*pair>*/0),
        new Card("ten",  /*cardnumber>*/35,/*suit>*/ 3, /*str8>*/ 10,   /*pair>*/0),
        new Card("jack", /*cardnumber>*/36,/*suit>*/ 3, /*str8>*/ 11,   /*pair>*/0),
        new Card("queen",/*cardnumber>*/37,/*suit>*/ 3, /*str8>*/ 12,   /*pair>*/0),
        new Card("king", /*cardnumber>*/38,/*suit>*/ 3, /*str8>*/ 13,   /*pair>*/0),

        new Card("ace",  /*cardnumber>*/39,/*suit>*/ 4, /*str8>*/ 1,    /*pair>*/0),
        new Card("two",  /*cardnumber>*/40,/*suit>*/ 4, /*str8>*/ 2,    /*pair>*/0),
        new Card("three",/*cardnumber>*/41,/*suit>*/ 4, /*str8>*/ 3,    /*pair>*/0),
        new Card("four", /*cardnumber>*/42,/*suit>*/ 4, /*str8>*/ 4,    /*pair>*/0),
        new Card("five", /*cardnumber>*/43,/*suit>*/ 4, /*str8>*/ 5,    /*pair>*/0),
        new Card("six",  /*cardnumber>*/44,/*suit>*/ 4, /*str8>*/ 6,    /*pair>*/0),
        new Card("seven",/*cardnumber>*/45,/*suit>*/ 4, /*str8>*/ 7,    /*pair>*/0),
        new Card("eight",/*cardnumber>*/46,/*suit>*/ 4, /*str8>*/ 8,    /*pair>*/0),
        new Card("nine", /*cardnumber>*/47,/*suit>*/ 4, /*str8>*/ 9,    /*pair>*/0),
        new Card("ten",  /*cardnumber>*/48,/*suit>*/ 4, /*str8>*/ 10,   /*pair>*/0),
        new Card("jack", /*cardnumber>*/49,/*suit>*/ 4, /*str8>*/ 11,   /*pair>*/0),
        new Card("queen",/*cardnumber>*/50,/*suit>*/ 4, /*str8>*/ 12,   /*pair>*/0),
        new Card("king", /*cardnumber>*/51,/*suit>*/ 4, /*str8>*/ 13,   /*pair>*/0)
    };

    public List<int> randomList = new List<int>();
    public List<Player> players;
    public List<Card> boardList = new List<Card>();                                               
    public List<Card> playerInHand = new List<Card>();
    public List<Card> test = new List<Card>();


    public List<Card> deletedList = new List<Card>();

    public List<Card> flushList = new List<Card>();

    public Card firstPair;
    public Card secondPair;
    public Card thirdPair;


    public Card flushHighCard;
    public Card card;

    void Start()
    {
        Resetter();
        RandomNumberPuller(7, boardList);
        SwitchMethod(boardList);
        FlushChecker(boardList);
    }
    public void Resetter()
    {
        boardList.Clear();
        AddingBackDeletedCards(deletedList);
        deletedList.Clear();
    }
    public List<Card> AddingBackDeletedCards(List<Card> list)
    {
        foreach (var item in list)
        {
            cardList.Add(item);
        
        }
        return cardList;
    }
    public void checkingForChanges(List<Card> list)
    {
        list = list.OrderBy(x => x.straightNumber).ToList();
        foreach (Card acard in list)
        {
            print($"card name is {acard.cardName}, card id number is {acard.cardIDNumber}, card suit is {acard.cardSuit}, straight number is {acard.straightNumber}, pair number is {acard.pairNumber}");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Resetter();
            RandomNumberPuller(7, boardList);
            SwitchMethod(boardList);
            FlushChecker(boardList);
            PairChecker(boardList);
        }
    }
    /*
    public void ListMakerTwo(List<Card> listOne,List<int> listTwo)
    {
        playerInHand.Add(cardList[listTwo[0]]);
        playerInHand.Add(cardList[listTwo[1]]);
    }
    */
    public void PairChecker(List<Card> list)
    {
        list = list.OrderBy(x => x.straightNumber).ToList();
        int a = 0;
        int b = 1;
        int pair = 0;
        bool pairNumberOne = false;
        bool pairNumberTwo = false;
        bool pairNumberThree = false;

        foreach (var item in list)
        {
            Debug.Log($"<color=orange>  </color> <color=grey>Pair list__{item.straightNumber} </color>.");
            if (b >= 0 && b < list.Count)
            {
                if (list[a].straightNumber == list[b].straightNumber)
                {
                    pair++;
                    if (pair == 1)
                    {
                        pairNumberOne = true;

                        //firstPair = list[b];                                                                         //TODO do i need to cast here???

                        firstPair = (Card)list[b];
                        Debug.Log($"<color=orange>THIS IS A Pair of>>{list[b].straightNumber}'s!!<< //<< </color> <color=grey></color>.");
                    }
                    if (pair == 2)
                    {
                        pairNumberTwo = true;
                        secondPair = (Card)list[b];
                        
                        Debug.Log($"<color=orange>THIS IS A Pair of>>{list[b].straightNumber}'s!!<< //<< </color> <color=grey></color>.");
                    }
                    if (pair == 3)
                    {
                        pairNumberThree = true;
                        thirdPair = (Card)list[b];
                        
                        Debug.Log($"<color=orange>THIS IS A Pair of>>{list[b].straightNumber}'s!!<< //<< </color> <color=grey></color>.");
                    }
                }
                a++;
                b++;
            }
        }
                                                                                        //TODO make it to where it finds the the greater of the two pair!

        if (pairNumberOne == true)
        {
            Debug.Log($"<color=yellow>THIS IS A Pair of>>{firstPair.straightNumber}'s!!<< //<< </color> <color=grey></color>.");
        }
        if (pairNumberTwo == true)
        {
            Debug.Log($"<color=yellow>THIS IS A Pair of>>{secondPair.straightNumber}'s!!<< //<< </color> <color=grey></color>.");
        }
        if (pairNumberThree == true)
        {
            Debug.Log($"<color=yellow>THIS IS A Pair of>>{thirdPair.straightNumber}'s!!<< //<< </color> <color=grey></color>.");
        }
        
    }

    public void ThreeOfAKindChecker(List<Card> list)
    {
        list = list.OrderBy(x => x.straightNumber).ToList();
        int a = 0;
        int b = 1;
        int c = 2;
        foreach (var item in list)
        {
            if (c >= 0 && c < list.Count)
            {
                if (list[a].straightNumber == list[b].straightNumber && list[b].straightNumber == list[c].straightNumber)
                {
                    Debug.Log($"<color=pink>This is a Three of kind >>{list[b].cardName}'s!!<< //<< </color> <color=grey> FOR EACH LOOP 1 </color>.");
                    
                }
                a++;
                b++;
                c++;
            }
        }
    }


    public Card FlushHigh(List<Card> list ,int suit)
    {
        flushList = list.Where(x => x.cardSuit == suit).ToList();
        var ace = list.Where(x => x.straightNumber == 1).ToList();
        foreach (var item in flushList)
        {
            print("this is flushList straightnumber>__" + item.straightNumber + "item suit" + item.cardSuit);
        }
        if (flushList.Exists(x=>x.straightNumber==1))
        {
            flushHighCard = list.Where(x => x.straightNumber == 1).FirstOrDefault();
            Debug.Log($"<color=red>this sure as fuck better be an ace!</color> <color=grey>  </color>.");
        }
        else
        {
            flushHighCard = flushList.OrderByDescending(x => x.straightNumber).FirstOrDefault(x=>x.straightNumber>=1);  //why does this work some times and not others...
        }
        return flushHighCard;
    }

    public void FlushChecker(List<Card> list)
    {
        int diamonds = 0; //this is cardSuit-1
        int spades = 0;   //this is cardSuit-2
        int hearts = 0;   //this is cardSuit-3
        int clubs = 0;    //this is cardSuit-4

        foreach (var item in list)
        {
            if (item.cardSuit == 1)
            {
                diamonds++;  
            }
            if(item.cardSuit == 2)
            {
                spades++;
            }
            if (item.cardSuit == 3)
            {
                hearts++;
            }
            if (item.cardSuit == 4)
            {
                clubs++;
            }
        }
            print("you have this many diamonds__" + diamonds);
            print("you have this many spades  __" + spades);
            print("you have this many hearts  __" + hearts);
            print("you have this many clubs   __" + clubs);

        if (diamonds >= 5)
        {
            FlushHigh(list,1);
            Debug.Log($"<color=aqua>this is a flush this is the high diamonds >>{flushHighCard.straightNumber}--{flushHighCard.cardIDNumber}--{flushHighCard.cardName}  << //<< </color> <color=grey>  </color>.");
        }
        if (spades >= 5)
        {
            FlushHigh(list,2);
            Debug.Log($"<color=aqua>this is a flush this is the high spades >>{flushHighCard.straightNumber}--{flushHighCard.cardIDNumber}--{flushHighCard.cardName}  << //<< </color> <color=grey>  </color>.");
        }
        if (hearts >= 5)
        {
            FlushHigh(list,3);
            Debug.Log($"<color=aqua>this is a flush this is the high hearts >>{flushHighCard.straightNumber}--{flushHighCard.cardIDNumber}--{flushHighCard.cardName}  << //<< </color> <color=grey>  </color>.");
        }
        if (clubs >= 5)
        {
            FlushHigh(list,4);
            Debug.Log($"<color=aqua>this is a flush this is the high clubs >>{flushHighCard.straightNumber}--{flushHighCard.cardIDNumber}--{flushHighCard.cardName}  << //<< </color> <color=grey>  </color>.");
        }
    }
    public void TestingIndex(List<Card> list)
    {
        list = list.OrderBy(x => x.straightNumber).ToList();
        List<Card> distinct = list.GroupBy(card => card.straightNumber).Select(g => g.First()).ToList();
        list = distinct.OrderBy(x => x.straightNumber).ToList();
        foreach (var item in list)
        {
            print(item.straightNumber);
            Debug.Log($"<color=aqua>list[1].straightNumber >>{list[1].straightNumber}<< //<< </color> <color=grey> FOR EACH LOOP 1 </color>.");
        }
    }

    public void SwitchMethod(List<Card> list)
    {
        IEnumerable<Card> listStraightNumber = list.OrderBy(x => x.straightNumber).Distinct();

        List<Card> distinct = list.GroupBy(card => card.straightNumber).Select(g => g.First()).ToList();

        distinct.OrderBy(x => x.straightNumber).ToList();
        list = distinct.OrderBy(x => x.straightNumber).ToList();
        int straightTry = 1;
        int a = 0;
        int b = 1;
        int i = 0;
        
        int straightControlNumber = 0;
        int S = 0;

        CheckingForFiveOrTen(list);

        foreach (var item in list)
        {
            print("straightlist card>>"+list[i].straightNumber);
            //Debug.Log($"<color=green>StraightNumber list >>>{list[i].straightNumber}</color><color=grey></color>.");
            i++;
        }
        foreach (var item in list)
        {
            switch (straightControlNumber)
            {
                case 1:
                    if (list[a].straightNumber + 1 == list[b].straightNumber)                                                                   //TODO pic the highest straight only...
                    {
                        S++;
                        if (S >= 7)
                        {
                            Debug.Log($"<color=lime>you have a straight {list[b].straightNumber} high!!</color><color=grey></color>.");
                            CheckingListAndAddingA_B();
                        }
                        else if (S >= 6)
                        {
                            Debug.Log($"<color=lime>you have a straight {list[b].straightNumber} high!!</color><color=grey></color>.");
                            CheckingListAndAddingA_B();
                        }
                        else if (S >= 5)
                        {
                            Debug.Log($"<color=lime>you have a straight {list[b].straightNumber} high!!</color><color=grey></color>.");
                            CheckingListAndAddingA_B();
                        }
                        else
                        {
                            CheckingListAndAddingA_B();
                        }
                    }
                    else
                    {
                        //Debug.Log($"<color=yellow>case 1 eles started</color><color=grey></color>.");
                        straightControlNumber = 5;
                    }
                    break;
                case 2:
                    print("this is case two you have no straight at all!!");
                    break;

                case 3:
                    print("something went wrong");
                    break;

                case 5:
                    S = 0;
                    straightTry++;
                    if (straightTry == 2)
                    {
                        if (2 >= 0 && 2 < list.Count)
                        {
                            a = 1;
                            b = 2;
                            straightControlNumber = 1;
                        }
                        else
                        {
                            print("this is straight try (2) some thing not right List to SHORT!!!! ");
                            straightTry = 4;
                        }
                    }
                    if (straightTry == 3)
                    {
                        if (3 >= 0 && 3 < list.Count)
                        {
                            a = 2;
                            b = 3;
                            straightControlNumber = 1;
                        }
                        else
                        {
                            print("this is straight try (3) some thing not right List to SHORT!!!! ");
                            straightTry = 4;
                        }
                    }
                    if (straightTry >= 4)
                    {
                        Debug.Log($"<color=grey>No straight straight try is = 4</color><color=grey></color>.");
                        break;
                    }
                    
                    break;
                default:
                    break;
            }
        }
        void CheckingForFiveOrTen(List<Card> cards)
        {
            bool ten = false;
            bool eleven = false;
            bool twelve = false;
            bool thirteen = false;
            bool ace = false;

           
            foreach (var item in cards)                                            //TODO this does not need to be a foreach loop just need to see if list has 5 or 10....
            {
                if (item.straightNumber == 5 || item.straightNumber == 10)
                {
                    print("chance for a straight! with a >> 5 or 10 <<!!!");
                    straightControlNumber = 1;

                    foreach (var T in cards)
                    {
                        
                        if (T.straightNumber == 10)
                        {
                            ten = true;
                        }
                        if (T.straightNumber == 11)
                        {
                            eleven = true;
                        }
                        if (T.straightNumber == 12)
                        {
                            twelve = true;
                        }
                        if (T.straightNumber == 13)
                        {
                            thirteen = true;
                        }
                        if (T.straightNumber == 1)
                        {
                            ace = true;
                        }
                        if (ten==true&& eleven==true && twelve==true&& thirteen==true&&ace==true)
                        {
                            
                            Debug.Log($"<color=orange>YOU HAVE A STRAIGHT ACE HIGH {cards[1].straightNumber}</color><color=grey></color>.");  
                        }
                    }
                    print("this is the ace number>>" +ace);

                }
                
            }
            if(straightControlNumber != 1)
            {
                straightControlNumber = 2;
            }
        }

        void CheckingListAndAddingA_B()
        {
            print($"this is list count{list.Count} and this is b ={b}");
            if (b > 0 && b + 1 < list.Count)
            {
                a++;
                b++;
            }
            else
            {
                straightControlNumber = 5;
                straightTry = 5;
            }
        }
    }

    public void StraightChecker(List<Card> list)
    {
       

        IEnumerable<Card> listStraightNumber = list.OrderBy(x => x.straightNumber).Distinct();

        List<Card> distinct = list.GroupBy(card => card.straightNumber).Select(g => g.First()).ToList();
        distinct.OrderBy(x => x.straightNumber).ToList();
        list = distinct.OrderBy(x=>x.straightNumber).ToList();

        int a = 0;
        int b = 1;
        int i = 0;
        
        
        foreach (var item in list)
        {
            print("this is straightlist from straight checker " + item.straightNumber);
        }


        foreach (var item in list)
        {
            if (b >= 0 && b <= list.Count)
            {
                i++;
                Debug.Log($"<color=blue>number of times it has checked>>{i}<< high</color> <color=grey></color>.");
                if (list[a].straightNumber+1 == list[b].straightNumber)//is 1 == 2
                {
                    if (b > 0 && b+1 < list.Count) 
                    { 
                        a++;
                        b++;
                    }

                    if (list[a].straightNumber + 1 == list[b].straightNumber) //is 2 == 3
                    {
                        if (b > 0 && b+1 < list.Count)
                        { 
                            a++;
                            b++;
                        }

                        if (list[a].straightNumber + 1 == list[b].straightNumber)//is 3 == 4
                        {
                            if (5 > 0 && 5 <= list.Count) 
                            { 
                                a++;
                                b++; 
                            }

                            if (list[a].straightNumber + 1 == list[b].straightNumber)//is 4 == 5
                            {
                                Debug.Log($"<color=aqua>straight >>{list[b].straightNumber}<< high</color> <color=grey></color>.");
                                if ( b > 0 && b <= list.Count)
                                { 
                                    a++;
                                    b++;
                                }

                                if (list[a].straightNumber + 1 == list[b].straightNumber)//is 5 == 6
                                {
                                    if (b > 0 && b <= list.Count)
                                    {
                                        a++;
                                        b++;
                                    }

                                    if (list[a].straightNumber + 1 == list[b].straightNumber)//is 6 == 7
                                    {
                                        Debug.Log($"<color=aqua>straight >>{list[b].straightNumber}<< high</color> <color=grey></color>.");
                                    }
                                    Debug.Log($"<color=aqua>straight >>{list[b].straightNumber}<< high</color> <color=grey></color>.");
                                }
                                
                            }
                                
                        }
                    }
                    
                }



                /*
                else
                {
                    straightCounter++;
                    if (straightCounter == 2)
                    {
                        if (2 >= 0 && 2 < list.Count)
                        {
                            a = 1;
                            b = 2;
                        }
                    }
                    if (straightCounter == 3)
                    {
                        if (3 >= 0 && 3 < list.Count)
                        {
                            a = 2;
                            b = 3;
                        }
                    }
                    if(straightCounter >= 4)
                    {
                        Debug.Log($"<color=grey>No straight</color><color=grey></color>.");
                        break;
                    }
                }
                */
            }
        }
    }
    public List<Card> RandomNumberPuller(int listLenght,List<Card> newListMade)
    {
        int rand;
        rand = Random.Range(0, cardList.Count);      
        for (int i = 0; i < listLenght; i++)
        {    
            newListMade.Add(cardList[rand]);
            //playerInHand.Add(cardList[rand]);
            deletedList.Add(cardList[rand]);
            cardList.Remove(cardList[rand]);

            rand = Random.Range(0, cardList.Count);
        }
        print("this is new CardList count!! " + cardList.Count);
        return newListMade;
    }
}
