using UnityEngine;
using System.Collections;

public class BossPos : MonoBehaviour 
{
	void Start () 
	{
	}

	void Update () 
	{
	}

	void OnTriggerEnter (Collider col) 
	{
		if(col.gameObject.tag == "Player")
		{
			//Enemyとぶつかった時実行
			//true//false
			GameObject.Find("BOSS").GetComponent<Bosstar>().enabled = true;
		}
	}
}
