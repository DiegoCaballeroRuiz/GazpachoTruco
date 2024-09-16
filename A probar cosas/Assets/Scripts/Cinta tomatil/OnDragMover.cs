using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnDragMover : MonoBehaviour
{
    private Transform _mTransfom;
    private FixedDirectionTomatoMover _movement;

    private void Awake()
    {
        _mTransfom = transform;
        _movement = GetComponent<FixedDirectionTomatoMover>();
    }

    #region drag
    public void OnMouseDown() //Drag starts
    {
        _movement.enabled = false;
    }

    public void OnMouseDrag()
    {
        float zPosition = _mTransfom.position.z;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        _mTransfom.position = new Vector3(mousePosition.x, mousePosition.y, zPosition);
    }
    

    public void OnMouseUp() //Drag stops
    {
        _movement.enabled = true;
    }
    #endregion

}
