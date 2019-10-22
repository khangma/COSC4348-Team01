using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderPool : MonoBehaviour
{
    public int boulderPoolSize = 5;
    public GameObject boulderPrefab;
    public float spawnRate = 4f;
    public float boulderMin = -1f;
    public float boulderMax = 3.5f;


    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawn;
    private float spawnXPosition = 10f;
    private int currentBoulder = 0;
    private GameObject[] boulders;


    // Start is called before the first frame update
    void Start()
    {
        timeSinceLastSpawn = 0f;
        boulders = new GameObject[boulderPoolSize];
        for (int i = 0; i < boulderPoolSize; i++)
        {
            boulders[i] = (GameObject)Instantiate(boulderPrefab, objectPoolPosition, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (GameControl.instance.gameOver == false && timeSinceLastSpawn>= spawnRate)
        {
            timeSinceLastSpawn = 0;
            float spawnYPosition = Random.Range(-4f, -2f);
            boulders[currentBoulder].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentBoulder++;
            if (currentBoulder >= boulderPoolSize)
            {
                currentBoulder = 0;
            }
        }
    }
}
