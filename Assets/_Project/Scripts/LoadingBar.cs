﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Image Progress;
    public FloatSO value;

    public void UpdateProgress()
    {
        Progress.fillAmount = value.value;
    }
}
