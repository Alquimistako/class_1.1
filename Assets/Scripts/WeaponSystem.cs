using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
	[Header("生成間隔"), Range(0, 10)]
	public float interval = 3.5f;
	[Header("武器預製物")]
	public GameObject prefabWeapon;
	[Header("武器飛行")]
	public Vector2 power;

	private Transform player;
	private void SpawnWeapon()
	{
		GameObject temWeapon = Instantiate(prefabWeapon, transform.position, transform.rotation);

		Rigidbody2D rigWeapon = temWeapon.GetComponent<Rigidbody2D>();

		rigWeapon.AddForce(power);
	}

	private void Awake()
	{
		InvokeRepeating("SpawnWeapon", 0, interval);

		player = GameObject.Find("企鵝").transform;

	}
}
