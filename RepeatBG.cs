using UnityEngine;
using System.Collections;

public class RepeatBG : MonoBehaviour 
{

    private BoxCollider2D groundCollider;        
    private float groundHorizontalLength;        

    //Awake is called before Start.
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D> ();
        groundHorizontalLength = 22.11f;
    }

    //Update runs once per frame
    private void Update()
    {
        if (transform.position.x < -groundHorizontalLength - 3)
        {
            RepositionBackground();
        }
    }

    //Moves the object this script is attached to right in order to create our looping background effect.
    private void RepositionBackground()
    {
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2) transform.position + groundOffSet;
    }
}
