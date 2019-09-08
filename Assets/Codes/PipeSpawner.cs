using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    public float height;
    public GameObject pipe;

    private float timer = 0;


    private void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            Destroy(newPipe, 15);

            timer = 0;
        }

        timer += Time.deltaTime;

    }
}