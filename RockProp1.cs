using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockProp1 : MonoBehaviour
{
    public int rockPoolSize = 5;
    public GameObject rockPrefab;
    public float spawnRate = 4f;
    public float rockMin = -1f;
    public float rockMax = 2.5f;

    private GameObject[] rocks;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeLastSpawn;
    private float spawnX = 10f;
    private int currentRock = 0;

    // Start is called before the first frame update
    void Start()
    {
        rocks = new GameObject[rockPoolSize];
        for (int i = 0; i < rockPoolSize; i++)
        {
            rocks[i] = (GameObject)Instantiate(rockPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeLastSpawn += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeLastSpawn >= spawnRate)
        {
            timeLastSpawn = 0;
            float spawnY = Random.Range(rockMin, rockMax);
            rocks[currentRock].transform.position = new Vector2(spawnX, spawnY);
            currentRock++;
            if (currentRock >= rockPoolSize)
            {
                currentRock = 0;
            }
        }
    }
}
