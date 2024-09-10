using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildButtonFunctionality : MonoBehaviour
{

    public bool _returnInstead;
    [HideInInspector] public int _amount;

    private BuildCreator _buildCreator;
    private void Awake()
    {
        _returnInstead = false;
        _amount = 1;

        _buildCreator = GetComponent<BuildCreator>();
    }

    public void Click()
    {
        if (!_returnInstead) _buildCreator.BuyBuilding();
        else _buildCreator.RemoveBuilding();
    } 
}
