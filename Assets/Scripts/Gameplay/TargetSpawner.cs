using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{

    public float yMin;

    public float yMax;

    public float MinTimeInterval;

    public float MaxTimeInterval;

    public bool GameOver = false;

    public GameObject TargetRef;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnTargets");
    }

    // Update is called once per frame
    public IEnumerator SpawnTargets()
    {
        float RandY = 0;

        float RandTimeInterval = 0;

        while (!GameOver)
        {
            RandY = Random.Range(yMin, yMax);

            RandTimeInterval = Random.Range(MinTimeInterval, MaxTimeInterval);

            Vector3 Spawn = new Vector3(transform.position.x, RandY, transform.position.z);

            GameObject target = Instantiate(TargetRef.gameObject, Spawn, new Quaternion());

            EnemyMovementBehavior MovingScript = target.GetComponent<EnemyMovementBehavior>();

            MovingScript.StartCos = Random.Range(-1, 1);

            yield return new WaitForSeconds(RandTimeInterval);

        }
    }
}
