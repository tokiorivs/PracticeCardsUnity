using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    public float boardWidth = 4;
    public float boardHeight = 4;
    public float screenWidth = 1080;
    public float screeHeight = 1920;
    float cardWidth;
    float cardHeight;
    public float margin;

    public List<GameObject> ListSelectedCards;
    public List<GameObject> ListCopy;
    public List<GameObject> ListOnGame;

    public GameObject card;
    float newPosX;
    float newPosY;

    public CardImages cardImages;
    public GameObject cartaPrueba;
    public bool verifyCardEvent = false;



    private void Awake()
    {
        RectTransform CardRectTransform = card.GetComponent<RectTransform>();
        cardWidth = CardRectTransform.sizeDelta.x;
        cardHeight = CardRectTransform.sizeDelta.y;
        ListCopy = new List<GameObject>();

    }

    void Start()
    {
        // CameraPosition();}
        Debug.Log("empezo el start");
        ListCopy = DuplicateCards(ListSelectedCards, ListCopy);
        ListOnGame = new List<GameObject>(ListCopy);
        restartList(ListCopy);
        CreateBoard();
        SetupCards();

    }
    public bool getCardEvent()
    {
        return verifyCardEvent;
    }
    public bool SetCardEvent(bool cardEvent)
    {
        verifyCardEvent = cardEvent;
        return verifyCardEvent;

    }
    void SetupCards()
    {

        for (int i = 0; i < boardWidth; i++)
        {

            for (int j = 0; j < boardHeight; j++)
            {
                float coordX = (i * (cardWidth * 1.05f)) + (1080 / 2) + ((boardWidth / 2) * -(cardWidth));
                float coordY = (j * (cardHeight * 1.05f)) + (1920 / 2) + ((boardHeight / 2) * -(cardHeight));

                //creamos una nueva carta de forma random de la lista de 16 scriptable cards disponibles
                var cardObject = ListCopy[UnityEngine.Random.Range(0, ListCopy.Count)];
                var cardInfo = cardObject.GetComponent<CardImages>();
                bool cardStateInvoke = cardInfo.GetIsInvoke();
                Debug.Log(cardStateInvoke);
                    GameObject newCards = Instantiate(cardObject, new Vector3(coordX, coordY, -4), Quaternion.identity);
                    ListCopy.Remove(cardObject);
                    newCards.transform.SetParent(this.transform);
                    cardInfo.SetIsInvoke(true);
            }

        }
    }
    public void CardVerification()
    {
        CardImages card_1 = new CardImages(); // Assign a value to the 'card_1' variable.
        card_1.GetCardType();
    }
    public List<GameObject> DuplicateCards(List<GameObject> lista, List<GameObject> listToCopy)
    {

        for( int i = 0; i < lista.Count; i++)
        {
            listToCopy.Add(lista[i]);
            listToCopy.Add(lista[i]);
        }
        return listToCopy;

    }

    void restartList(List<GameObject> list)
    {
        for( int i = 0; i < ListCopy.Count; i++)
        {
           list[i].GetComponent<CardImages>().SetIsInvoke(false); 
           Debug.Log("la carta "+ list[i] +"esta en modo " +list[i].GetComponent<CardImages>().GetIsInvoke());
        }
    }

    void CameraPosition()
    {
        newPosX = screenWidth / 2;
        newPosY = screeHeight / 2;
        Camera.main.transform.position = new Vector3(newPosX - 50, newPosY - 50, -10);
        margin = 550;
    }
    void CreateBoard()
    {
        for (int i = 0; i < boardWidth; i++)
        {

            for (int j = 0; j < boardHeight; j++)
            {
                float coordX = (i * (cardWidth * 1.05f)) + (1080 / 2) + ((boardWidth / 2) * -(cardWidth));
                float coordY = (j * (cardHeight * 1.05f)) + (1920 / 2) + ((boardHeight / 2) * -(cardHeight));
                //creamos un nuevo componente
                GameObject newCard = Instantiate(card, new Vector3(coordX, coordY, -5), Quaternion.identity);
                newCard.transform.SetParent(this.transform);
                newCard.GetComponent<Tile>()?.Setup(i, j, this);
            }

        }

    }

}