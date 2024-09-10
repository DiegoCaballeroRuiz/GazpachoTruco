using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeResourceAdder : MonoBehaviour
{
    [SerializeField] private float _value;
    public float Value { get { return _value; } set {  _value = value; } }

    [SerializeField] private bool _removeItInstead;
    [SerializeField] private GazpachoContainer _container;

    public void AddValue()
    {
        float value = _value;
        if (_removeItInstead) value = -value;

        _container.GazpachoLiters += value;
    }
}
