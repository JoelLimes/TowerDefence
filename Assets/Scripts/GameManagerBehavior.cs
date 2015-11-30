using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/**
* ...
* @author Joel Limes
* ...
**/

public class GameManagerBehavior : MonoBehaviour 
{	
	public Text goldLabel;
	public Text waveLabel;

	private int gold;
	public int Gold {
		get { return gold; }
		set {
			gold = value;
			goldLabel.GetComponent<Text>().text = " " + gold;
		}
	}
	
	// Use this for initialization
	void Start () 
	{
		Gold = 500;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
