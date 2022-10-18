using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;



//ctr k ctr c for commenting out!!
//ctr k ctr u for uncommenting !!



public class Main : MonoBehaviour
{
    public List<Card> cardList = new List<Card>();



   

    public List<Card> boardList = new List<Card>();
    public List<Card> deletedList = new List<Card>();
    public List<Card> playerOneTestList = new List<Card>(); //this is a test list(not really needed at the moment)...

    public List<Card> highCardList = new List<Card>();

    public List<int> pairsKeyList = new List<int>();
    public List<Card> pairList = new List<Card>();
    public List<Card> bestPair = new List<Card>();
    public List<Card> secondBestPair = new List<Card>();

    public List<Card> straightListTest = new List<Card>();
    public List<int> straightIntList = new List<int>();
    public List<Card> straightList = new List<Card>();
    public List<int> straightRangeList = new List<int>();

    public List<Card> orderedFlushList = new List<Card>();
    public Card flushHighCard;

    public List<Card> fullHouseTrips = new List<Card>();
    public List<Card> fullHousePair = new List<Card>();

    public List<Card> straightFlushList = new List<Card>();

    // testing stuff below ***********************

    public List<Card> playerHandCardsShowed = new List<Card>();//testing this shows cards
    public List<Card> boardCardsShowed = new List<Card>(); //testing this shows cards


    public Transform card_1Transform;
    public Transform card_2Transform;

    public Transform flopCardOneTransform;
    public Transform flopCardTwoTransform;
    public Transform flopCardThreeTransform;
    public Transform turnCardTransform;
    public Transform riverCardTransform;

    public CardData playerCardOne = null;//TODO destroy clones made!!
    public CardData playerCardTwo = null;//TODO destroy clones made!!
    public CardData flopCardOne = null;//TODO destroy clones made!!
    public CardData flopCardTwo = null;//TODO destroy clones made!!
    public CardData flopCardThree = null;//TODO destroy clones made!!
    public CardData turnCard = null;//TODO destroy clones made!!
    public CardData riverCard = null;//TODO destroy clones made!!

    public int bestHandNumber;

    // testing stuff above ****************

    public bool highCardBool = false;
    public bool pairBool = false;
    public bool twoPairBool = false;
    public bool threeOfAKindBool = false;
    public bool straightBool = false;
    public bool flushBool = false;
    public bool fullHouseBool = false;
    public bool fourOfAKindBool = false;
    public bool straightFlushBool = false;
    public bool royalFlushBool = false;

   

    void Start()
    {
        //GameManager.Instance.Cards;
        foreach (CardData cardData in GameManager.Instance.Cards) {

            cardList.Add(new Card(cardData.cardName, cardData.cardIDNumber, cardData.cardSuit, cardData.cardSuitName, cardData.straightNumber, cardData.cardObject));
        }
        Resetter();
        RandomNumberPuller(7, boardList);
        BestHandCheckerHolder(playerOneTestList);
        TestingShit(playerOneTestList);
    }

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            for (int i = 0; i < 300; i++)
            {
                print("this is I count> " + i);
                if (straightFlushBool == true)
                {
                    i = 300;
                }
                else
                {
                    Resetter();
                    RandomNumberPuller(7, boardList);
                    BestHandCheckerHolder(playerOneTestList);
                }
            }
        }
    }
    
    public void TestingShit(List<Card> list)//TODO destroy clones made!!
    {
        /*
        var fistcard = list[0];
        var secondcard = list[1];

        var flop_1 = list[2];
        var flop_2 = list[3];
        var flop_3 = list[4];

        var _turn = list[5];

        var _river = list[6];



        var realfirstcard = carddatalist.where(x => x.cardname == fistcard.cardname).where(x => x.cardsuit == fistcard.cardsuit).select(x => x);
        var realsecondcard = carddatalist.where(x => x.cardname == secondcard.cardname).where(x => x.cardsuit == secondcard.cardsuit).select(x => x);

        var realfloponecard = carddatalist.where(x => x.cardname == flop_1.cardname).where(x => x.cardsuit == flop_1.cardsuit).select(x => x);
        var realfloptwocard = carddatalist.where(x => x.cardname == flop_2.cardname).where(x => x.cardsuit == flop_2.cardsuit).select(x => x);
        var realflopthreecard = carddatalist.where(x => x.cardname == flop_3.cardname).where(x => x.cardsuit == flop_3.cardsuit).select(x => x);

        var realturncard = carddatalist.where(x => x.cardname == _turn.cardname).where(x => x.cardsuit == _turn.cardsuit).select(x => x);

        var realrivercard = carddatalist.where(x => x.cardname == _river.cardname).where(x => x.cardsuit == _river.cardsuit).select(x => x);

        playercardone = realfirstcard.firstordefault();
        playercardtwo = realsecondcard.firstordefault();

        flopCardOne = realFlopOneCard.FirstOrDefault();
        flopCardTwo = realFlopTwoCard.FirstOrDefault();
        flopCardThree = realFlopThreeCard.FirstOrDefault();

        turnCard = realTurnCard.FirstOrDefault();
        riverCard = realRiverCard.FirstOrDefault();
        */
    }
    public void BoardCardsCreator()
    {
        Instantiate(flopCardOne.cardObject, flopCardOneTransform);
        Instantiate(flopCardTwo.cardObject, flopCardTwoTransform);
        Instantiate(flopCardThree.cardObject, flopCardThreeTransform);
        Instantiate(turnCard.cardObject, turnCardTransform);
        Instantiate(riverCard.cardObject, riverCardTransform);
    }
    public void CardObjectCreator()
    {
        Instantiate(playerCardOne.cardObject, card_1Transform);
        Instantiate(playerCardTwo.cardObject, card_2Transform);
    }
    public void BestHand()//testing this
    {
        switch (bestHandNumber)
        {
            case 1:
                print("your best hand is High Card.");
                break;
            case 2:
                print("your best hand is pair");
                break;
            case 3:
                print("your best hand is two pair");
                break;
            case 4:
                print("your best hand is three of a kind");
                break;
            case 5:
                print("your best hand is a straight");
                break;
            case 6:
                print("your best hand is a flush");
                break;
            case 7:
                print("your best hand is a full house");
                break;
            case 8:
                print("your best hand is a four of a kind");
                break;
            case 9:
                print("your best hand is a straight Flush");
                break;
            case 10:
                print("your best hand is royal Flush");
                break;
        }
    }
    public void BoolHandControler()   //testing this...
    {
     
        if(highCardBool == true) { bestHandNumber = 1; }

        if (pairBool == true) { bestHandNumber = 2; }

        if (twoPairBool == true) { bestHandNumber = 3; }

        if (threeOfAKindBool == true) { bestHandNumber = 4; }

        if (straightBool == true) { bestHandNumber = 5; }

        if (flushBool == true) { bestHandNumber = 6; }

        if (fullHouseBool == true) { bestHandNumber = 7; }

        if (fourOfAKindBool == true) { bestHandNumber = 8; }

        if (straightFlushBool == true) { bestHandNumber = 9; }

        if (royalFlushBool == true) { bestHandNumber = 10; }
    }
    public void BestHandCheckerHolder(List<Card> playerList)
    {
        FourOfAKind(playerList);
        FullHouse(playerList);
        FlushCheck(playerList);
        StraightCheckerAndStraightFlush(playerList);
        ThreeOfAKindChecker(playerList);
        PairChecker(playerList);
        HighCard(playerList);
        BoolHandControler();//this is bool testing
        BestHand();//this is switch

        CardObjectCreator();
        BoardCardsCreator();
        //TestingShit(playerHandCardsShowed);
        //PlayerCardData(playerHandCardsShowed);//testing
    }
    public List<Card> AddingBackDeletedCards(List<Card> list)
    {
        foreach (var item in list) {
            cardList.Add(item);
        }
        return cardList;
    }
    public void Resetter()
    {
        if (highCardList != null)
        {
            highCardList.Clear();
        }
        if (fullHousePair != null && !fullHousePair.Any())
        {
            fullHousePair.Clear();
        }
        if (fullHouseTrips != null && !fullHouseTrips.Any())
        {
            fullHouseTrips.Clear();
        }
        if (pairsKeyList != null)
        {
            pairsKeyList.Clear();
        }
        if (bestPair != null)
        {
            bestPair.Clear();
        }
        if (secondBestPair != null)
        {
            secondBestPair.Clear();
        }
        if (fullHouseTrips != null)
        {
            fullHouseTrips.Clear();
        }
        if (fullHousePair != null)
        {
            fullHousePair.Clear();
        }
        if (straightFlushBool == true)
        {
            straightFlushList.Clear();
        }
        pairList.Clear();
        playerOneTestList.Clear();
        boardList.Clear();
        AddingBackDeletedCards(deletedList);

        playerHandCardsShowed.Clear();

        bestHandNumber = 1;
        deletedList.Clear();
        highCardBool = false;
        pairBool = false;
        twoPairBool = false;
        threeOfAKindBool = false;
        straightBool = false;
        flushBool = false;
        fullHouseBool = false;
        fourOfAKindBool = false;
        straightFlushBool = false;
        royalFlushBool = false;
    }
    public void CheckingPlayersForBestHand(List<Card> List)
    {
        BestHandCheckerHolder(List);
    }
    public void HighCard(List<Card> list)
    {
        highCardList = list.OrderBy(x => x.straightNumber).ToList();

        foreach (var item in highCardList)
        {
            Debug.Log($"<color=orange></color><color=grey>highCardList is straightNumber> {item.straightNumber}, NAME> {item.cardName}, SUIT> {item.cardSuit}, CARD-ID-NUMBER> {item.cardIDNumber} Card Suit Name>>{item.cardSuitName} </color>");
        }

        if (highCardList[0].straightNumber == 1)
        {
           // Debug.Log($"<color=orange>You have a {highCardList[0].cardName}high!</color> <color=grey> </color>");
        }
        else
        {
            int index = highCardList.IndexOf(highCardList.LastOrDefault());
           // Debug.Log($"<color=orange>You have a {highCardList[index].straightNumber}--{highCardList[index].cardName} high</color> <color=grey> </color>.");
        }
    }
    public void PairChecker(List<Card> list)     
    {
        var pairGroupsList = list.GroupBy(x => x.straightNumber)
                            .Where(x => x.Count() == 2)
                            .OrderBy(x => x.Key)
                            .ToList();
       
        foreach (var item in pairGroupsList){

            pairsKeyList.Add(item.Key);
            foreach (var _card in item){

                pairList.Add(_card);
            }
        }

        if(pairList.Count == 2){OnePair();}
        if(pairList.Count >= 3){TwoPair();}

        void OnePair(){
            
            pairBool = true;
            Debug.Log($"<color=orange> you have a pair of {pairList[0].cardName}s </color> <color=grey> {pairList[0].cardName} of {pairList[0].cardSuitName} and a {pairList[1].cardName} of {pairList[1].cardSuitName}  </color>.");
        }

        void TwoPair() {

            twoPairBool = true;
            var highestPairNumber = pairList.Max(x => x.straightNumber);
            var secondHighestPair = pairList.OrderByDescending(x => x.straightNumber).Skip(2).First().straightNumber;
            if (pairList.Any(x=>x.cardName == "ace")){

                bestPair = pairList
                    .Where(x => x.cardName == "ace")
                    .Select(x => x)
                    .ToList();
                secondBestPair = pairList
                    .Where(s => s.straightNumber == highestPairNumber)
                    .Select(s => s)
                    .ToList();
            }
            else {
                bestPair = pairList
                    .Where(x => x.straightNumber == highestPairNumber)
                    .Select(x => x)
                    .ToList();
                secondBestPair = pairList
                    .Where(s => s.straightNumber == secondHighestPair)
                    .Select(s=>s)
                    .ToList();
            }
            Debug.Log($"<color=orange> you have Two Pair! {bestPair[0].cardName}s and {secondBestPair[0].cardName}s! </color> <color=grey> {bestPair[0].cardName} of {bestPair[0].cardSuitName}, {bestPair[1].cardName} of {bestPair[1].cardSuitName} and  {secondBestPair[0].cardName} of {secondBestPair[0].cardSuitName}, {secondBestPair[1].cardName} of {secondBestPair[1].cardSuitName} </color>.");
        }
    }
    public void ThreeOfAKindChecker(List<Card> list)   
    {
        var threeOfAKind = list.GroupBy(x => x.straightNumber)
                            .Where(x => x.Count() == 3)
                            .OrderBy(x => x.Key)
                            .ToList();
        foreach (var item in threeOfAKind) {

            threeOfAKindBool = true;
            foreach (var _card in item) {

                Debug.Log($"<color=blue> you have a Three of a Kinds,{_card.straightNumber},-- {_card.cardIDNumber},-- {_card.cardName},-- {_card.cardSuit} </color> <color=grey>  </color>.");
            }
        }
    }
    public void StraightCheckerAndStraightFlush(List<Card> list)  
    {
        straightListTest = list.GroupBy(x => x.straightNumber)
                           .Select(x => x.First())
                           .OrderBy(x => x.straightNumber)
                           .ToList();
        var counter = 0;
        var fiveOrTen = straightListTest.Where(x => x.straightNumber == 5 || x.straightNumber == 10).ToList();

        if (straightListTest.Count() < 5 || fiveOrTen.Count() == 0) {
            return;
        }

        int index = 0, secondIndex = 1, thirdIndex = 2;

        StraightIterator(index);
        StraightIterator(secondIndex);
        StraightIterator(thirdIndex);

        void StraightIterator(int indexer){

            if (straightIntList.Count > 0) {

                straightIntList.Clear();
            }
            straightRangeList = Enumerable.Range(straightListTest[indexer].straightNumber, 5).ToList();      //todo make this a private var?

            if (straightListTest[indexer].straightNumber >= 10 && straightListTest.Any(a=>a.cardName=="ace")){

                foreach (var item in straightListTest){
                    if (item.cardName == "ace"){

                        item.straightNumber = 14;
                        straightIntList = straightRangeList.Intersect(straightListTest.Select(x => x.straightNumber)).ToList();
                    }
                }
            }
            else {
                straightIntList = straightRangeList.Intersect(straightListTest.Select(x => x.straightNumber)).ToList();  //***make it so if indexer is past 8 or so that ace is now straight#14
            }
            if (straightIntList.Count() >= 5) {
                MakingStraightListAndCheckingForFlush();
                counter++;
            }
        }
        void MakingStraightListAndCheckingForFlush(){

            straightList = straightListTest.Where(item1 => straightIntList
                                           .Any(item2 => item1.straightNumber == item2))
                                           .OrderBy(s=>s.straightNumber)
                                           .ToList();
            StraightFlushChecker(straightList);
        }
        if (counter >= 1){   HighestStraightAnnouncer(); }

        void HighestStraightAnnouncer(){

            straightBool = true;
            Debug.Log($"<color=aqua> You have a straight {straightList.LastOrDefault().cardName} high!</color> <color=grey>  </color>.");
            foreach (var __item in straightList){
                Debug.Log($"<color=aqua>Here are the cards that make the straight >>{__item.straightNumber} </color> <color=grey>  </color>.");
            }
        }
        foreach (var item in straightListTest) { //   ***this code below puts ace straightNuber back to one***
            if (item.cardName == "ace"){
                item.straightNumber = 1;
            }
        }
    }
    public void FlushCheck(List<Card> list)
    {
        var flushList = list.GroupBy(x => x.cardSuit)
                          .Where(x => x.Count() == 5)
                          .OrderBy(x => x.Key)//do you need this orderby?
                          .ToList();

        foreach (var item in flushList) {

            flushBool = true;
            foreach (var items in item){

                orderedFlushList.Add(items);
                Debug.Log($"<color=yellow>you have a Flush! this is the card suit{items.cardSuit}, this is the card name{items.cardName} this is the card ID{items.cardIDNumber}this is the straightNumber>> {items.straightNumber}</color> <color=grey>  </color>.");
            }
            FlushHighCardFinder();
        }
        void FlushHighCardFinder() {

            orderedFlushList = orderedFlushList.OrderByDescending(x => x.straightNumber).ToList();
            if (orderedFlushList.LastOrDefault().straightNumber == 1){

                flushHighCard = orderedFlushList.LastOrDefault();
            }
            else{

                flushHighCard = orderedFlushList.FirstOrDefault();
            }
            Debug.Log($"<color=green> you have a Flush {flushHighCard.cardName} High!!!</color> <color=grey>card ID number>{flushHighCard.cardIDNumber}  </color>.");
        }
    }
    public void FullHouse(List<Card> list)     //todo return the highest of the two pair and the highest of the trips...(dont forget about ACES Check dont just do last of default)
    {
        var threeOfAkindKeyList = list.GroupBy(x => x.straightNumber)
                            .Where(x => x.Count() == 3)
                            .OrderBy(x => x.Key)
                            .ToList();

        var pairGroupsList = list.GroupBy(x => x.straightNumber)
                           .Where(x => x.Count() == 2)
                           .OrderBy(x => x.Key)
                           .ToList();

        foreach (var tripGroupKey in threeOfAkindKeyList) {

            foreach (var tripCard in tripGroupKey){

                fullHouseTrips.Add(tripCard);
                // Debug.Log($"<color=yellow> You have a FullHouse straightNumber>> {tripCard.straightNumber},card Id number>> {tripCard.cardIDNumber} </color> <color=grey>  </color>.");
            }
        }
        foreach (var PairGroupKey in pairGroupsList){

            foreach (var pairCard in PairGroupKey){

                fullHousePair.Add(pairCard);
                // Debug.Log($"<color=yellow> fullhouse pair >straight number>>{pairCard.straightNumber},card Id number>> {pairCard.cardIDNumber} </color> <color=grey>  </color>.");
            }
        }
        if (fullHousePair.Count >= 2 && fullHouseTrips.Count >= 3) {

            Debug.Log($"<color=green> You have a FullHouse  {fullHouseTrips.LastOrDefault().straightNumber}'s full of {fullHousePair.LastOrDefault().straightNumber}'s  </color> <color=grey>  </color>.");
            fullHouseBool = true;
        }
    }
    public void FourOfAKind(List<Card> list)
    {
        var FourOfAKind = list.GroupBy(x => x.straightNumber)
                            .Where(x => x.Count() == 4)
                            .OrderBy(x => x.Key)
                            .ToList();

        foreach (var item in FourOfAKind)
        {
            fourOfAKindBool = true;
            Debug.Log($"<color=green>You have a four of a kind! {item.Key}'s!!<< //<< </color> <color=grey>  </color>.");
            foreach (var items in item)
            {
                Debug.Log($"<color=yellow>This is a Four of kind straightNumber>> {items.straightNumber}, four of a kindcard ID number {items.cardIDNumber},    </color> <color=grey>  </color>.");
            }
        }
    }
    public void StraightFlushChecker(List<Card> list)
    {
        var FlushGroup = list.GroupBy(x => x.cardSuitName).Where(s => s.Count() >= 5).Select(s => s).ToList();
        foreach (var item in FlushGroup) {
            
            foreach (var items in item){
                straightFlushBool = true;
                straightFlushList.Add(items);
                Debug.Log($"<color=white>StraighFlushCheckerList>> {items.straightNumber},  {items.cardName},  {items.cardSuitName} </color> <color=grey>  </color>.");
            }
        }
    }
    public List<Card> RandomNumberPuller(int listLenght, List<Card> newListMade)//todo see if i can make it more random using system.Random with Next() to change seed...
    {
        int rand;
        rand = Random.Range(0, cardList.Count);
        for (int i = 0; i < listLenght; i++){

            playerHandCardsShowed.Add(cardList[rand]);//testing!!

            playerOneTestList.Add(cardList[rand]);
            newListMade.Add(cardList[rand]);
            highCardList.Add(cardList[rand]);
            deletedList.Add(cardList[rand]);
            cardList.Remove(cardList[rand]);
            rand = Random.Range(0, cardList.Count);
        }
        return newListMade;
    }
}
