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

    public List<CardScriptObject> ListSelectedCards;
    public List<CardScriptObject> ListVerificatedCards;

    public GameObject card;
    float newPosX;
    float newPosY;
    public GameObject[] availableCards;

    public List<GameObject> ListAvaiblecards;
    public CardImages cardImages;
    public GameObject cartaPrueba;
    private void Awake()
    {
        RectTransform CardRectTransform = card.GetComponent<RectTransform>();
        cardWidth = CardRectTransform.sizeDelta.x;
        cardHeight = CardRectTransform.sizeDelta.y;
    }

    void Start()
    {
        // CameraPosition();
        CreateBoard();
        SetupCards();
        ListAvaiblecards = new List<GameObject>(availableCards);
        ListSelectedCards = new List<CardScriptObject>();
        ListVerificatedCards = new List<CardScriptObject>();

    }
    void SetupCards()
    {
        for (int i = 0; i < boardWidth; i++)
        {

            for (int j = 0; j < boardHeight; j++)
            {
                float coordX = (i * (cardWidth * 1.05f)) + (1080 / 2) + ((boardWidth / 2) * -(cardWidth));
                float coordY = (j * (cardHeight * 1.05f)) + (1920 / 2) + ((boardHeight / 2) * -(cardHeight));

                // var selectedCard = ListAvaiblecards[UnityEngine.Random.Range(0, ListAvaiblecards.Count)];
                var selectedCardScriptObject = ListSelectedCards[UnityEngine.Random.Range(0, ListSelectedCards.Count)];
                var CardScriptObject = selectedCardScriptObject.GetCardButton();    
                //creamos un nuevo componente
                GameObject newCard = Instantiate(CardScriptObject, new Vector3(coordX, coordY, -4), Quaternion.identity);

                newCard.transform.SetParent(this.transform);
                newCard.GetComponent<Card>()?.Setup(i, j, this);
                // ListAvaiblecards.Remove(selectedCard);
                // listCardScriptObjects.Remove(selectedCardScriptObject);
            }

        }
    }
//     public void SwapCardss()
// {
//     cartaPrueba.transform.Rotate(0, 10, 0);
// }
   
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