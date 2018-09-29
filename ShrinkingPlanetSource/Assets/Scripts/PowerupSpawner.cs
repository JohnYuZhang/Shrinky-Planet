using System.Collections;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{

    public GameObject powerupPrefab;

    void Start()
    {
        StartCoroutine(SpawnPowerup());
    }

    IEnumerator SpawnPowerup()
    {
        Vector3 pos = Random.onUnitSphere * 1f;
        Instantiate(powerupPrefab, pos, Quaternion.identity);

        yield return new WaitForSeconds(Random.Range(1,10));

        StartCoroutine(SpawnPowerup());
    }

}
