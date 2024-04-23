using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class CardImages : MonoBehaviour
{
    [SerializeField]public GameObject frontImage;
    [SerializeField] public GameObject backImage;
    public GameObject GetFrontImage()
    {
        return frontImage;
    }
    public GameObject GetBackImage()
    {
        return backImage;
    }
}
