using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    [SerializeField] private CubeSpawner cubeSpawner;
    [SerializeField] private CubesPool cubesPool;

    [SerializeField] private TMP_InputField inputSpeedText;
    [SerializeField] private TMP_InputField inputDistanceText;
    [SerializeField] private TMP_InputField inputTimeText;

    public void SetSpeed()
    {
        float res;
        if (float.TryParse(inputSpeedText.text, out res))
            cubeSpawner.SetSpeed(res);
    }

    public void SetDistance()
    {
        float res;
        if (float.TryParse(inputDistanceText.text, out res))
            cubeSpawner.SetDistance(res);
    }

    public void SetTime()
    {
        float res;
        if (float.TryParse(inputTimeText.text, out res))
            cubeSpawner.SetTime(res);
    }

    public void ClearPool()
    {
        cubesPool.ClearPool();
    }
}
