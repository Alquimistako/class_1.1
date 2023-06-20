using UnityEngine;

public class DamageEnemy : DamageBasic
{
	[Header("¶Ë®`­È")]
	public GameObject prefabDamage;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name.Contains("»É¤M"))
		{
			Damage(50);

			Instantiate(prefabDamage, transform.position, transform.rotation);
		}
	}
}
