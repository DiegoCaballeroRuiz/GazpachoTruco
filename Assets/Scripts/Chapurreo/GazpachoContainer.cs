using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.TerrainTools;
using UnityEngine;

[CreateAssetMenu(fileName = "Gazpacho Container", menuName = "Scriptable Objects/Gazpacho Container")]
public class GazpachoContainer : ScriptableObject
{
    public float GazpachoLiters { get; set; }
    public float GPS { get; private set; }

    public IEnumerator GPSCoroutine()
    {
        float prevLitersVal = GazpachoLiters;
        float prevGPSVal = 0;
        while (true)
        {
            yield return new WaitForSeconds(1);

            float trueGPS = GazpachoLiters - prevLitersVal;
            GPS = trueGPS >= 0 ? trueGPS : prevGPSVal;

            prevGPSVal = GPS;
            prevLitersVal = GazpachoLiters;
        }
    }
}
