using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int x;
    public int y;
    public Board board;
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
    public CardType cardType;
    public void Setup(int x_, int y_, Board board_)
    {
        this.x = x_;
        this.y = y_;
        this.board = board_;
    }
}
