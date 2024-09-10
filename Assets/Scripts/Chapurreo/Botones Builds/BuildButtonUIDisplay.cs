using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildButtonUIDisplay : MonoBehaviour
{
    [SerializeField] private string _buildingName;

    [SerializeField] private TMP_Text _typeText, _priceText, _quantityText;

    private void Awake()
    {
        _typeText.text = _buildingName; 
    }

    public void UpdateDisplay(float price, int quantity)
    {
        _priceText.text = string.Format("{0:0.00}", price.ToString()) + "L";
        _quantityText.text = quantity.ToString();
    }
}
