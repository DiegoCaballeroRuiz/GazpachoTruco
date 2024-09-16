using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OnTriggerEnterTomatoDestroyer : MonoBehaviour
{

    [SerializeField] private bool _isFinalContainer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FixedDirectionTomatoMover tomato = collision.GetComponent<FixedDirectionTomatoMover>();

        if(tomato != null)
        {

            bool haveToPunish = _isFinalContainer && tomato.IsBadTomato
                                || !_isFinalContainer && !tomato.IsBadTomato;

            if (haveToPunish) Punish();
            
            Destroy(tomato.gameObject);
        }
    }

    private void Punish()
    {
        Debug.Log("Punished!");
    }
}
