using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// S.
/// </summary>

public class SE : MonoBehaviour 
{
	public AudioClip sound01;

	private void UpdateTurret()
	{
		if(Input.GetMouseButton(0))
		{
			GetComponent<AudioSource>().PlayOneShot(sound01);
		}
	}
}
