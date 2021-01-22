using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public FloatSO bossHealth;
    public EventSO HealthChanged;

    private void Start()
    {
        StartCoroutine(AttackBoss());
    }

    IEnumerator AttackBoss()
    {
        while (bossHealth.value > .5f)
        {
            yield return new WaitForSeconds(.1f);
            bossHealth.value -= .01f;
            HealthChanged.Raise();
        }
    }

}
