using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;

    [Tooltip("The time to despawn a bullet that was shot")]
    [SerializeField]
    private float _despawnTimer;

    public Rigidbody Rigidbody
    {
        get
        {
            return _rigidbody;
        }
            
    }
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _despawnTimer); 
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject, 0);
    }
}
