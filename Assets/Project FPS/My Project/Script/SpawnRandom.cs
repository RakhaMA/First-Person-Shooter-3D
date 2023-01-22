using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject targetPrefab;
    public float spawnInterval;
    public int maxZombie;
    private int countZombie = 0;
    public GameObject[] spawnSpots;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartInstantiate", 1, spawnInterval);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartInstantiate()
    {
        Vector3 newSpot = spawnSpots[Random.Range(0, spawnSpots.Length)].transform.position;

        GameObject temp = GameObject.Instantiate(targetPrefab, newSpot, targetPrefab.transform.rotation);
        temp.SetActive(true);
        
        countZombie += 1;
        if (countZombie >= maxZombie)
        {
            CancelInvoke("StartInstantiate");
        }
    }
}
