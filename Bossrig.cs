using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Bossrig.
/// </summary>

public class Bossrig : MonoBehaviour {
	float vector = 1; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		//vector
		this.transform.position += new Vector3(0, 0, -0.04f);
		vector++;
	}
}
