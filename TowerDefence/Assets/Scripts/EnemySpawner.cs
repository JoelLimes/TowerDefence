using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    [SerializeField] private GameObject _objectToSpawn;
    [SerializeField] private float _spawnTimer;

	// Use this for initialization
	void Start () {
        InvokeRepeating ("SpawnEnemy", 0.5f, _spawnTimer);
	}
	private void SpawnEnemy()
    {
        GameObject obj = Instantiate (_objectToSpawn, this.transform.position, Quaternion.identity) as GameObject;
        obj.transform.SetParent(this.transform);
    }

}
