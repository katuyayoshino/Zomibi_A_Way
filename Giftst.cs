using UnityEngine;
using System.Collections;



public class Giftst : MonoBehaviour 
{
	public Texture[] PlayerTexture;
	public float gifNum = 0;
	public float fps = 24;

	void Update () 
	{
		gifNum = Time.time * fps;
		gifNum = gifNum % PlayerTexture.Length;
		GetComponent<Renderer>().material.mainTexture = PlayerTexture[(int)gifNum];
		Debug.Log( Mathf.Floor(gifNum));
	
	}
}
