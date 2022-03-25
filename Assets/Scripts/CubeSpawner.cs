using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    [SerializeField] private float cubesDistance;
    [SerializeField] private float cubesSpeed;

    [SerializeField] private float timeBetweenCubesSpawn = 2.0f;

    [SerializeField] private Vector3 spawnPoint;
    [SerializeField] private float spawnRandomSpread = 5.0f;

    [SerializeField] private CubesPool cubesPool;

    [SerializeField] private float maxSpeed = 100f;

    void Start()
    {
        StartCoroutine(StartCubeSpawner());
    }

    IEnumerator StartCubeSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBetweenCubesSpawn);
            cubesPool.CreateCube(new Vector3(spawnPoint.x + Random.Range(-spawnRandomSpread, spawnRandomSpread),
                                            spawnPoint.y + Random.Range(-spawnRandomSpread, spawnRandomSpread),
                                            spawnPoint.z + Random.Range(-spawnRandomSpread, spawnRandomSpread)),
                                                cubesDistance, cubesSpeed);
        }

    }

    public void SetSpeed(float speed)
    {
        if (speed >= 0 && speed <= maxSpeed)
            cubesSpeed = speed;
    }

    public void SetDistance(float distance)
    {
        cubesDistance = distance;
    }

    public void SetTime(float time)
    {
        if (time > 0)
            timeBetweenCubesSpawn = time;
    }

}
