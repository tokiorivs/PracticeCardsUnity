using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CardImages : MonoBehaviour
{
    [SerializeField] GameObject frontImage;
    [SerializeField] GameObject backImage;
    [SerializeField] bool isFlipped = false;
    [SerializeField] bool isMatched = false;
    [SerializeField] bool isInvoke = false;
    [SerializeField] CardType cardType;
    bool verifyCardEvent;
    GameObject board;

    public enum CardType
    {
        bloqueo,
        cero,
        cinco,
        mas_cuatro,
        nueve,
        reverse,
        seis,
        siete
    }

    void Start()
    {
        // GameObject verifyCardEvent = board.GetComponent<GameObject>();
    }
    public CardType GetCardType()
    {
        Debug.Log(cardType);
        return cardType;
    }

    public GameObject getFrontImage()
    {
        Debug.Log("se añadio el frontImage");
        return frontImage;
    }
    public GameObject getBackImage()
    {
        return backImage;
    }

    public void SwapCard()
    {
        GetCardType();
        // bool pruebaget =board.getCardEvent();
        // Debug.Log("el evento es "+ pruebaget);
        // board.SetCardEvent(false);
        // Debug.Log("en el cardTwist");
        backImage.transform.Rotate(0, 90, 0);

    }
    public bool GetIsInvoke()
    {
        return isInvoke;
    }
    public bool SetIsInvoke(bool value)
    {
        isInvoke = value;
        return isInvoke;
    }
   
    
}
