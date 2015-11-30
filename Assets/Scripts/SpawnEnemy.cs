using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/**
* ...
* @author Joel Limes
* ...
**/

public class SpawnEnemy : MonoBehaviour 
{
	public GameObject[] waypoints;
	

	[SerializeField]
	private List<GameObject> FastFood;

	[SerializeField]
	private float spawnTime;


	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("SpawnEnemies", spawnTime, spawnTime);
		GetComponent<MoveEnemy>().waypoints = waypoints;

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void SpawnEnemies()
	{
		Instantiate(FastFood[Random.Range(0,FastFood.Count)]);
	}
}
