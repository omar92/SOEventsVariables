using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "playersSharedData", menuName = "SO/data/playersSharedData", order = 0)]
public class PlayersSharedData : ScriptableObject
{
    public float MaxHealth;
    public float initSpead;
    public float MaxSpead;
    public float MaxLVL;
    public float MaxScore;
}
