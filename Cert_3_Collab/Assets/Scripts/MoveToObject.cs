using UnityEngine;

public class MoveToObject : MonoBehaviour
{
    public Transform target;
    public float speed;
    void Update()
    {
        Vector3 dir = (target.position - transform.position) * 0.4f;
        Vector3 velocity = dir * speed;
        transform.position += velocity * Time.deltaTime;
    }
}
