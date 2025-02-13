using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BoxSpawner : MonoBehaviour
{
    [FormerlySerializedAs("box")] [SerializeField] private GameObject[] boxes;
    [SerializeField] private Transform dispenserPosition;

    [SerializeField] private float spawnRate = 5.0f;
    [SerializeField] private float spawnCooldown;
    
    int randomInt; 

    void Start()
    {
        InvokeRepeating("BoxSpawn", spawnRate, spawnRate);
    }

    void BoxSpawn()
    {
        randomInt = Random.Range(0, boxes.Length);
        Instantiate(boxes[randomInt], dispenserPosition.position, dispenserPosition.rotation);
        
    }
}
