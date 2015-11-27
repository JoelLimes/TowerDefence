using UnityEngine;
using System.Collections;

public class FollowPath : MonoBehaviour {
    //author Daniel Hofman
    public Transform[] waypoints;
    public float moveSpeed;
    private int currentPoint;

	// Use this for initialization
	void Start () {
        transform.position = waypoints[0].position;
        currentPoint = 0;	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position == waypoints[currentPoint].position)
        {
            currentPoint++;
        }
        else 
        {
            walk();
        }

       // transform.position = Vector2.MoveTowards(transform.position, waypoints[currentPoint].transform.position, moveSpeed * Time.deltaTime);

	}
    void walk ()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentPoint].transform.position, moveSpeed * Time.deltaTime);
    }
   
}
