using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventoryUI : MonoBehaviour
{
    private TextMeshProUGUI ButtonText;
    // Start is called before the first frame update
    void Start()
    {
        ButtonText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateButtonText(PlayerINV playerINV)
    {
        ButtonText.text = playerINV.NumberOfButtons.ToString();
    }
}