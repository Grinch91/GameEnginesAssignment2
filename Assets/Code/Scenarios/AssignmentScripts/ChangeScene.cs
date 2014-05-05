using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad(GameObject.FindGameObjectWithTag("sceneHandler"));
		StartCoroutine("Change");
	}

	void OnLevelWasLoaded(int level)
	{
		StartCoroutine("Change");
	}

	IEnumerator Change()
	{
		//Application.LoadLevel();
		if(Application.loadedLevel == 0)
		{
			yield return new WaitForSeconds(30.0f);
			Application.LoadLevel("gateScene");
		}
		if(Application.loadedLevel == 1)
		{
			yield return new WaitForSeconds(16.0f);
			Application.LoadLevel("mainFightScene");
		}
		if(Application.loadedLevel == 2)
		{
			yield return new WaitForSeconds(20.0f);
			Application.LoadLevel("explosion1Scene");
		}
		if(Application.loadedLevel == 3)
		{
			yield return new WaitForSeconds(5.0f);
			Application.LoadLevel("reinforcementsScene");
		}
		if(Application.loadedLevel == 4)
		{
			yield return new WaitForSeconds(8.0f);
			Application.LoadLevel("explosion2Scene");
		}
		if(Application.loadedLevel == 5)
		{
			yield return new WaitForSeconds(5.0f);
			Application.LoadLevel("endScene");
		}

		//Waits 2 seconds*/
	}
}
