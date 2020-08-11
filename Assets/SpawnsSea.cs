using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnsSea : MonoBehaviour
{
    public GameObject SeaSpawn;
    public GameObject SeaPrefab;
    public int GameSpeed;

    public void OnTriggerEnter(Collider SeaPrefab)
    {
        SpawnSea();
    }

    public void SpawnSea()
    {
        GameObject sea = Instantiate(SeaPrefab, SeaSpawn.transform.position, Quaternion.identity);
    }
}
