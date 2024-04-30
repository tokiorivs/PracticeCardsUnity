using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CardImages : MonoBehaviour
{
    [SerializeField] GameObject frontImage;
    [SerializeField] GameObject backImage;
    string saludo = "Hola";
    public void SwapCard()
    {
        Debug.Log("en el cardTwist");
        frontImage.transform.Rotate(0, 90, 0);

    }
    
}
