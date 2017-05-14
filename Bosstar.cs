using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Bosstar.
/// </summary>

public class Bosstar : MonoBehaviour 
{
	float vector = 1; 
	void Start () 
	{
		//transform.Translate( 0 , -45 , 0 );
	}

	void Update () 
	{
		//vector
		this.transform.position += new Vector3(0, 0, -0.1f);
		vector++;
	}
}
