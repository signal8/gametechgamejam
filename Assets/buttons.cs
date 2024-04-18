using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
	private AudioSource sound;
	private MeshRenderer mr;
	private BoxCollider bc;
	private bool collected = false;
	void Start()
	{
		sound = GetComponent<AudioSource>();
		mr = GetComponent<MeshRenderer>();
		bc = GetComponent<BoxCollider>();
	}

	void Update()
	{
		if (!(collected == true && sound.isPlaying == false)) return;
		Destroy(gameObject);
	}

    private void OnTriggerEnter(Collider other)
    {
        PlayerINV playerINV = other.GetComponent<PlayerINV>();

        if(playerINV!= null)
        {
            playerINV.ButtonCollected();
	    sound.Play();
        	collected = true;
		mr.enabled = false;
		bc.enabled = false;
        }
    }
}
