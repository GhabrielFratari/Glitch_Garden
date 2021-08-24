using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackersPrefabs;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }

    }

    private void SpawnAttacker()
    {
        int randomAttacker = Random.Range(0, attackersPrefabs.Length);
        Spawn(randomAttacker);
    }

    private void Spawn(int randomAttacker)
    {
        Attacker newAttacker = Instantiate(attackersPrefabs[randomAttacker], transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
