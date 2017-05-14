using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Boss.
/// </summary>

public class Boss : MonoBehaviour 
{
	//敵の初期多力
	public float life = 50;

	void Start () 
	{
	}

	void Update () 
	{
		Debug.Log (life);
	}

	public void Damage ( float damage ) 
	{
		//体力から差し引く
		life -= damage; 
		if(life <= 0)
		{
			//体力が0以下になった時//死亡処理
			Dead(); 
		}
	}

	//死亡処理
	public void Dead () 
	{ 
		Application.LoadLevel ("Clear");
	}

}
