using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIGazpachoLitersDisplay : MonoBehaviour
{
    [SerializeField] private GazpachoContainer _container;
    [SerializeField] private TMP_Text _amountText, _gPSText;

    private void Start()
    {
        StartCoroutine(_container.GPSCoroutine());
    }

    private void Update()
    {
        float display = _container.GazpachoLiters;
        _amountText.text = $"{string.Format("{0:0.00}", display)} litros de Gazpachito";
        _gPSText.text = $"Your GPS is {string.Format("{0:0.00}", _container.GPS)}";
    }
}
