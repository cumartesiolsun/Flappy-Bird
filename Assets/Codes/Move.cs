using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;

    private void Start()
    {
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}