using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "card", fileName = "New CardScriptObject")]

public class CardScriptObject : ScriptableObject
{
    [SerializeField] GameObject cardButton;
    [SerializeField] bool isFlipped;
    [SerializeField] bool isInvoke = false;
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

    public bool GetIsInvoke()
    {
        return isInvoke;
    }
    public void SetIsInvoke(bool value)
    {
        isInvoke = value;
    }

    public bool GetIsFlipped()
    {
        return isFlipped;
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
