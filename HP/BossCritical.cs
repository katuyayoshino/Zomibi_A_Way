using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Boss critical.
/// </summary>

public class BossCritical : MonoBehaviour 
{
	//敵の初期多力
	public float life = 40;

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

