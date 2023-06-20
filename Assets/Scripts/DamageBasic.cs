using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    [Header("���")]
    public Database data;

	private float HP;

	private void Awake()
	{
		HP = data.HP;
	}
	public void Damage(float damage)
	{
	  HP -= damage;

	  print($"{gameObject.name} ��q�ѤU: {HP}");

	  if (HP <= 0) Dead();
	}
    private void Dead()
	{
	  print($"{gameObject.name} ���`");

	  

	}
}
