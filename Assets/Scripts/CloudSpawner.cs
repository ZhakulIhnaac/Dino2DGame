using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnRange = 3f;
    [SerializeField] float maxSpawnRange = 5f;
    [SerializeField] GameObject cloud;
    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnRange, maxSpawnRange));
            spawnCloud();
        }

    }

    private void spawnCloud()
    {
        Instantiate(cloud, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
