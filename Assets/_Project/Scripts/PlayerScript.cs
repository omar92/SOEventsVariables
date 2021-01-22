using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public BossHealth bossHealth;
    public PlayersSharedData playersData;
    

    private void Start()
    {
        StartCoroutine(AttackBoss());
    }

    IEnumerator AttackBoss()
    {
        while (GameManager.inistance.number>.5f)
        {
            yield return new WaitForSeconds(1);
            GameManager.inistance.number -= .1f;
        }
        SceneManager.LoadSceneAsync(1);

    }

}
