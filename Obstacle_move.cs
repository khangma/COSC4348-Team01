using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_move : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(- speed * Time.deltaTime, 0, 0);

        if (GameControl.instance.gameOver == true)
        {
            speed = 0;
        }
    }
}
