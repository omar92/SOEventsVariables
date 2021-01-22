using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Image Progress;
    public BossHealth bossHealth;

    void Update()
    {
        Progress.fillAmount = GameManager.inistance.number;
    }
}
