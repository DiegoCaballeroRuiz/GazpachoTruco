using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCreator : MonoBehaviour
{
    [SerializeField] private float _basePrice, _multiplier, _removeDemultiplier;
    public float CurrentPrice { get; private set; }

    [SerializeField] private ResourceAddingBuilding _building;
    [SerializeField] GazpachoContainer _container;
    private BuildButtonUIDisplay _display;
    
    public void BuyBuilding()
    {
        if(_container.GazpachoLiters >= CurrentPrice)
        {
            _container.GazpachoLiters -= CurrentPrice;
            _building.AddBuildings(1);
            CurrentPrice *= _multiplier;

            _display.UpdateDisplay(CurrentPrice, _building.Buildings);
        }
    }

    public void RemoveBuilding()
    {
        if (_building.RemoveBuildings(1) > 0)
        {
            _container.GazpachoLiters += CurrentPrice * _removeDemultiplier;
            CurrentPrice /= _multiplier;

            _display.UpdateDisplay(CurrentPrice, _building.Buildings);
        }
    }

    private void Start()
    {
        CurrentPrice = _basePrice;
        _display = GetComponent<BuildButtonUIDisplay>();
        _display.UpdateDisplay(_basePrice, 0);
    }
}
