using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNGManager : MonoBehaviour
{
    private bool PercentageBasedBoolean(float percentage) => Random.Range(1, 100) <= percentage;
}
