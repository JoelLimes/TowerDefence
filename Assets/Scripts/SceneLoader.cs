using UnityEngine;
using System.Collections;

/**
* ...
* @author Joel Limes
* ...
**/

public class SceneLoader : MonoBehaviour 
{
	public void Change(int scene) 
	{
		Application.LoadLevel (scene);
	}
}
