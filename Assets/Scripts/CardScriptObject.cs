using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "card", fileName = "New CardScriptObject")]

public class CardScriptObject : ScriptableObject
{
    [SerializeField] GameObject cardButton;
    [SerializeField] bool isFlipped = false;
    [SerializeField] bool isMatched = false;
    [SerializeField] bool isInvoke = false;
    CardImages cardImages;
    GameObject frontCard; 
    GameObject backCard;

    public enum CardType { 
        bloqueo,
        cero,
        cinco,
        mas_cuatro,
        nueve, 
        reverse,
        seis,
        siete};
    public CardType cardType;

    
    public bool GetItsMatched()
    {
        return isMatched;
    }
    public void SetIsMatched(bool value)
    {
        isMatched = value;
    }

    public bool GetIsFlipped()
    {
        return isFlipped;
    }
       public void SetIsFlipped(bool value)
    {
        isFlipped = value;
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
    
    public GameObject GetCardButton()
    {
        return cardButton;
    }
    public string GetCardType()
    {
        return cardType.ToString();
    }
}
