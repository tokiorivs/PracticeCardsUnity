using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CardImages : MonoBehaviour
{
    [SerializeField] GameObject frontImage;
    [SerializeField] GameObject backImage;
    Board board;
    void Start()
    {
        board = FindObjectOfType<Board>();
    }
    string saludo = "Hola";

    // la carta se voltea
    // se devuelve el card Type
    // si ha sido matcheada
    public void FlipCard()
    {
        if(board.verifyCard == false)
        {
         Debug.Log("estamos en el flipCard");
        }
    }
    public void SwapCard()
    {
        FlipCard();
        Debug.Log("en el cardTwist");
        frontImage.transform.Rotate(0, 90, 0);

    }
    
}
