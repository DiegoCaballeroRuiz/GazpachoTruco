using System.Collections;
using UnityEngine;

public class ResourceAddingBuilding : MonoBehaviour
{
    #region references
    [SerializeField] private float _baseValue;
    [SerializeField] private int _buildings;
    public int Buildings { get { return _buildings; } }

    [SerializeField] private bool _removeItInstead;

    [SerializeField] private GazpachoContainer _container;
    #endregion

    private void Start()
    {
        StartCoroutine(AddEverySecond());
    }

    public void AddBuildings(int quantity) => _buildings += quantity;

    public int RemoveBuildings(int quantity)
    {
        _buildings -= quantity;
        if (_buildings < 0)
        {
            int extraBuilings = -_buildings;
            _buildings = 0;
            return extraBuilings;
        }
        else return 0;
    }

    private void AddValue()
    {
        float valueToAdd = _baseValue * _buildings;
        if(_removeItInstead) valueToAdd = -valueToAdd;

        _container.GazpachoLiters += valueToAdd;
    }

    private IEnumerator AddEverySecond()
    {
        while (true)
        {
            AddValue();
            yield return new WaitForSeconds(1);
        }
    }
}
