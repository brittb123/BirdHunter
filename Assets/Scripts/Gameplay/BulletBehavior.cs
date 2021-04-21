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

    // A function to put the rigidbody and set it to be active
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _despawnTimer); 
    }

    // If the object colliding with the tag target is hit, 
    // it calls the destroy function
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
            Destroy(other.gameObject);
    }
}
