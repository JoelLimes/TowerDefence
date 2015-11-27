using UnityEngine;
using System.Collections;

public class TurretAI : MonoBehaviour 
{
	public float radius = 3;
	public Transform Spawnpos;
	public Transform bullet;
	
	private float waitTime = 0.5f;

	void Start()
	{
		
	}

	void Update()
	{

		transform.rotation = Quaternion.AngleAxis (GetAngle (GetTarget()) + 180, Vector3.forward);
		waitTime += Time.deltaTime;
		if (waitTime > .6f) 
		{
			Instantiate(bullet,Spawnpos.position, Spawnpos.rotation);
			waitTime = 0;

		}
	}


	// draw radius and give color
	void OnDrawGizmos() {
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, radius);
	}

	Vector3 GetTarget() {
		Collider2D[] colliders = Physics2D.OverlapCircleAll (transform.position, 3, LayerMask.GetMask("Enemy"));
		GameObject closestTarget = null;
		float smallestDistance = int.MaxValue;

		foreach (Collider2D coll in colliders) {
			float distance = Vector3.Distance(transform.position, coll.transform.position);

			if(distance < smallestDistance) {
				closestTarget = coll.gameObject;
				smallestDistance = distance;
			}
		}

		return closestTarget.transform.position;
	}


	float GetAngle(Vector3 target) {
		Vector3 distance = transform.position - target;
		float angle = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;
		return angle;
	}

}
 