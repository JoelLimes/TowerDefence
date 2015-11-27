using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour{
    //Daniel Hofman
    /*[SerializeField] private float _movementSpeed;
    [SerializeField] private float _waypointRadius;

    private Rigidbody2D rb2d;

    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D> ();
        PathData waypoints = GameObject.FindGameObjectsWithTag ("Path").GetComponent<PathData>
        path = new Path (waypoints.waypoints, waypoints.isLoopable);
    }
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 newVelocity = new Vector2(_movementSpeed, 0f);
        rb2d.velocity = newVelocity;
	
	}
    private void MovetoWaypoint()
    {
        Vector2 waypoint = path.GetCurrentWaypoint();
    }*/
}
