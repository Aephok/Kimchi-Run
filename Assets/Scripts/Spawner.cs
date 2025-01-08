using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    public float minSpawnDelay;
    public float maxSpawnDelay;
    [Header("References")]
    public GameObject[] gameobjects;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void OnEnable()
    {
        Invoke("Spawn", Random.Range(minSpawnDelay,maxSpawnDelay));
    }

    void OnDisable()
    {
        
        CancelInvoke();
    }
    // Update is called once per frame
   void Spawn()
    {
        var randomObject = gameobjects[Random.Range(0, gameobjects.Length)];
        Instantiate(randomObject, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
