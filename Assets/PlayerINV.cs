using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerINV : MonoBehaviour
{
    public int NumberOfButtons { get; private set; }
	private GameObject player;

	void Start()
	{
		player = GameObject.Find("NestedParentArmature_Unpack");
	}

    public void ButtonCollected()
    {
        NumberOfButtons++;
	player.SendMessage("Shrink");
    }
}
