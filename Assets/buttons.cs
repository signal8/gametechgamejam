using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerINV playerINV = other.GetComponent<PlayerINV>();

        if(playerINV!= null)
        {
            playerINV.ButtonCollected();
            gameObject.SetActive(false);
        }
    }
}
