using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerINV : MonoBehaviour
{
    public int NumberOfButtons { get; private set; }

    public void ButtonCollected()
    {
        NumberOfButtons++;
    }
}
