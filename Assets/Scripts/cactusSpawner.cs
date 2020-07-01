using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnRange = 2.5f;
    [SerializeField] float maxSpawnRange = 4f;
    [SerializeField] GameObject cactus;
    bool spawn = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnRange, maxSpawnRange));
            spawnCactus();
        }
    }

    private void spawnCactus()
    {
        Instantiate(cactus, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
