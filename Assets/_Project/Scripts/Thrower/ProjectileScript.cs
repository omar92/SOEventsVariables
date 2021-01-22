using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    public Transform bulletsPool;
    public float lifeTime;

    Rigidbody myRB;
    private void Awake()
    {
        myRB = GetComponentInChildren<Rigidbody>();
    }
    void OnEnable()
    {
        RemoveAfter(lifeTime);
    }

    private async void RemoveAfter(float lifeTime)
    {
        await Task.Delay((int)(1000 * lifeTime));
        transform.parent = bulletsPool;
        transform.position = bulletsPool.position;
        transform.rotation = Quaternion.identity;
        myRB.velocity = Vector3.zero;
        myRB.angularVelocity = Vector3.zero;
        transform.gameObject.SetActive(false);
    }
}
