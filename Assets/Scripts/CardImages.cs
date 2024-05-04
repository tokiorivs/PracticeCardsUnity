using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CardImages : MonoBehaviour
{
    [SerializeField] GameObject frontImage;
    [SerializeField] GameObject backImage;
    Board board;
    bool verifyCardEvent;

    void Start()
    {
        board = FindObjectOfType<Board>();
        verifyCardEvent = board.verifyCardEvent;
        
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

    // la carta se voltea
    // se devuelve el card Type
    // si ha sido matcheada
    public void FlipCard()
    {
        if( !verifyCardEvent)
        {
         Debug.Log("estamos en el flipCard");
        }
    }
    public void SwapCard()
    {
        FlipCard();
        board.saludo();
        Debug.Log("en el cardTwist");
        backImage.transform.Rotate(0, 90, 0);

    }
    
}
