using TMPro;
using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    [Header("資料")]
    public Database data;
	[Header("傷害值")]
	public GameObject prefabDamage;

	private float HP;

	private void Awake()
	{
		HP = data.HP;
	}
	public void Damage(float damage)
	{
		HP -= damage;

		print($"{gameObject.name} 血量剩下: {HP}");

		GameObject tempDamage = Instantiate(prefabDamage, transform.position, transform.rotation);
		tempDamage.transform.Find("傷害值文字").GetComponent<TextMeshProUGUI>().text = damage.ToString();

		if (HP <= 0) Dead();

		Destroy(tempDamage ,1);
	}
    protected virtual void Dead()
	{
	  print($"{gameObject.name} 死亡");
	}

}
