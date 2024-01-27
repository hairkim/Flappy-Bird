using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawner : MonoBehaviour
{

    public GameObject pipes;

    private float timeToSpawn = 1f;

    private float timeBetweenWaves = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //moves the block spawner with the player
        transform.Translate(Vector2.right * (float)3 / 2 * Time.deltaTime);

        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    public float topHeight;

    void SpawnBlocks()
    {
        float randomHeight = Random.Range((float) -0.5, (float) -3);

        transform.position = new Vector3(transform.position.x, randomHeight, transform.position.z);

        Vector3 bottom = transform.position;

        transform.position = new Vector3(transform.position.x, randomHeight + topHeight, transform.position.z);

        Vector3 top = transform.position;

        pipes.transform.position = bottom;
        Instantiate(pipes, bottom, Quaternion.identity);

        pipes.transform.position = top;
        Instantiate(pipes, top, Quaternion.identity);
    }
}
