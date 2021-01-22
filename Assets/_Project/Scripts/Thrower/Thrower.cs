using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    public Rigidbody bullet;
    public Transform muzzel;

    public float ProjectileVelocity;
    public int ReloadSpeed;

    public int magSize = 12;
    public int BulletsInMagzine = 12;
    public Transform bulletsBool;

    private void Awake()
    {
        Reload(0);
    }

    private void Start()
    {
        bullet.gameObject.SetActive(false);
    }

    public void Throw()
    {
        if (BulletsInMagzine > 0)
        {
            Rigidbody bulletRB = null;
            if (bulletsBool.childCount == 0)
            {
                bulletRB = GameObject.Instantiate(bullet);
            }
            else
            {
                var bullet = bulletsBool.GetChild(0);
                bullet.parent = null;
                bulletRB = bullet.GetComponent<Rigidbody>();

            }
            bulletRB.transform.position = muzzel.transform.position;
            bulletRB.velocity = muzzel.forward * ProjectileVelocity;
            bulletRB.gameObject.SetActive(true);
            BulletsInMagzine--;
        }
    }


    public void Reload()
    {
        Reload(ReloadSpeed);
    }
    private async void Reload(int realodTime)
    {
        await Task.Delay(realodTime);
        BulletsInMagzine = magSize;
    }



}
