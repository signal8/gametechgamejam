using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Larie : MonoBehaviour
{
	public TextAsset dialog;

	void Talk()
	{
		BasicInkExample sc = GameObject.Find("StoryController")
			.GetComponent<BasicInkExample>();

		sc.StartCharacterDialog(dialog);
	}
}
