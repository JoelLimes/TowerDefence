using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	
	public float maxHealth = 100f;
	public float currentHealth = 0f;
	public GameObject healthBar;
	
	void Start () 
	{
		currentHealth = maxHealth;
	}

	void Update () 
	{
		
	}
	
	void decreaseHealth()
	{
		currentHealth -= 10f;
		float calc_Health = currentHealth / maxHealth;
		SetHealthBar (calc_Health);
	}

	public void SetHealthBar(float myHealth)
	{
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z); 
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Bullet") 
		{
			decreaseHealth();
		}

		if(currentHealth <= 0)
		{
			Destroy(this.gameObject);
		}
	}
}
