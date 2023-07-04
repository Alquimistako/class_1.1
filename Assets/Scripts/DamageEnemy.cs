using UnityEngine;

public class DamageEnemy : DamageBasic	
{
	private DataEnemy dataEnemy;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name.Contains("»É¤M"))
		{
			Damage(50);
		}
	}
	
	protected override void Dead()
	{
		base.Dead();
		Destroy(gameObject);

		if (Random.value <= dataEnemy.expProbability)
		{
			Instantiate(dataEnemy.prefabExp, transform.position, transform.rotation);
		}
	}

}
