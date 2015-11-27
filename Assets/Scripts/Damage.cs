using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour 
{
//	[SerializeField]
	public int targetHealth = 30;
	
	int damage = 10;

	// Use this for initialization
	void Start () 
	{
		Debug.Log (targetHealth);
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		Debug.Log ("Test");
		if (coll.gameObject.tag == "Bullet") 
		{
			Destroy(this.gameObject);
		}
	}
}