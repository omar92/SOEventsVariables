using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "BossHealth", menuName = "SO/data/BossHealth", order = 0)]
public class BossHealth : ScriptableObject
{
    [Range(0,1)]
    public float value;
}
