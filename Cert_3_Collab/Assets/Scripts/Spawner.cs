using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject thingToSpawn;
    public float spawnInterval = 3.0f;
    private float spawnTimer = 0.0f;
    void Start()
    {
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnInterval)
        {
            spawnTimer = 0.0f;
            Instantiate(thingToSpawn,transform.position,Quaternion.identity);
        }
    }
}
