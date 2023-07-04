using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
	[Header("�ͦ����j"), Range(0, 10)]
	public float interval = 3.5f;
	[Header("�Z���w�s��")]
	public GameObject prefabWeapon;
	[Header("�Z������")]
	public Vector2 power;
	int direction;

	private Transform player;
	private void SpawnWeapon()
	{
		GameObject temWeapon = Instantiate(prefabWeapon, transform.position, transform.rotation);

		Rigidbody2D rigWeapon = temWeapon.GetComponent<Rigidbody2D>();

		direction=player.eulerAngles.y == 0 ? 1 : -1;

		rigWeapon.AddForce(new Vector2(power.x,power.y*direction));

		Destroy(temWeapon, 3);

		
	}

	private void Awake()
	{
		InvokeRepeating("SpawnWeapon", 0, interval);

		player = GameObject.Find("���Z").transform;
	}
}
