using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inistance = null;
    public FloatSO bossHealth;

    [Range(0, 1)]
    public float number;
    private void Awake()
    {
        if (inistance == null)
        {
            inistance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        number = 1;

        DontDestroyOnLoad(this);
        bossHealth.value = 1;

    }
}
