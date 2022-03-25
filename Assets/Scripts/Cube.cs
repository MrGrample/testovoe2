using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public void StartMoving(float distance, float speed)
    {
        Vector3 direction = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
        StartCoroutine(StartMovingEachFrame(direction, speed));
    }

    IEnumerator StartMovingEachFrame(Vector3 direction, float speed)
    {
        while (transform.position != direction)
        {   
            transform.position = Vector3.MoveTowards(transform.position, direction, speed * Time.deltaTime);
            yield return new WaitForFixedUpdate();
        }

        HideCube();

        yield return null;
    }

    private void HideCube()
    {
        this.gameObject.SetActive(false);
    }

}
