using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehavior : MonoBehaviour
{

    [SerializeField]
    private BulletSpawnBehavior _bulletScript;

    [SerializeField]
    private float _shotSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && _bulletScript)
            _bulletScript.Firing(transform.forward * _shotSpeed);
    }
}
