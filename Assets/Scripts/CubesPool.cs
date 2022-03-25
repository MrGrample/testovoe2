using UnityEngine;

public class CubesPool : MonoBehaviour
{
    [SerializeField] private int poolCount = 5;
    [SerializeField] private bool autoExpand = true;
    [SerializeField] private Cube cubePrefab;

    private PoolMono<Cube> pool;

    private void Start()
    {
        pool = new PoolMono<Cube>(cubePrefab, poolCount, this.transform);
        pool.autoExpand = this.autoExpand;
    }

    public void CreateCube(Vector3 position, float distance, float speed)
    {
        var cube = this.pool.GetFreeElement();
        cube.transform.position = position;
        cube.StartMoving(distance, speed);
    }

    public void ClearPool()
    {
        pool.DeactivateAllInPool();
    }
}