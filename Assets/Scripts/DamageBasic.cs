using TMPro;
using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    [Header("���")]
    public Database data;
	[Header("�ˮ`��")]
	public GameObject prefabDamage;

	private float HP;

	private void Awake()
	{
		HP = data.HP;
	}
	public void Damage(float damage)
	{
		HP -= damage;

		print($"{gameObject.name} ��q�ѤU: {HP}");

		GameObject tempDamage = Instantiate(prefabDamage, transform.position, transform.rotation);
		tempDamage.transform.Find("�ˮ`�Ȥ�r").GetComponent<TextMeshProUGUI>().text = damage.ToString();

		if (HP <= 0) Dead();

		Destroy(tempDamage ,1);
	}
    protected virtual void Dead()
	{
	  print($"{gameObject.name} ���`");
	}

}
