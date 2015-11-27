using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour 
{

	[SerializeField]
	private float health = 10;

	[SerializeField]
	private int maxHealth = 10;

	[SerializeField]
	private Image healthBar; 
	
	// Use this for initialization
	void Start () 
	{
		healthBar.fillAmount = (1.0f / maxHealth) * (health);
	}
	
	// Update is called once per frame
	void Update () 
	{
			
	}
}
