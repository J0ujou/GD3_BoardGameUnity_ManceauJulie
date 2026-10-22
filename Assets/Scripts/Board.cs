using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public List<GameObject> Cases;
    public int LastIndex => Cases.Count - 1;

    public int CalculateNewPosition(int actual, int number, out bool rebound)
    {
        int newPos = actual + number;
        rebound = false;

        if (newPos > LastIndex)
        {
            rebound = true;
            int tooMuch = newPos - LastIndex;
            newPos = LastIndex - tooMuch; // fais le nombre de cases qu'il reste mais en arrière
        }
        else if (newPos < 0)
        {
            newPos = 0;
        }
        return newPos;
    }
}
