using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	[SerializeField]
	private GameObject Enemy;

	[SerializeField]
	private float spawnTime;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("SpawnEnemy", spawnTime, spawnTime);
//		Instantiate (Enemy); 
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void SpawnEnemy()
	{
		var newEnemy = GameObject.Instantiate(Enemy);
	}
}
