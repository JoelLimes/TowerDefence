using UnityEngine;
using System.Collections;

public class BulletSpeed : MonoBehaviour 
{
//	[SerializeField]
	public float bulletSpeed = 20f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (new Vector3(1,0,0) * bulletSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "enemy") 
		{
			Destroy(this.gameObject);
		}
	}
}
