using UnityEngine;

[CreateAssetMenu(menuName = "Data/Enemy")]
public class DataEnemy : Database
{

    [Header("掉落經驗機率"), Range(0, 1)]
    public float expProbability;
    [Header("掉落經驗預製物")]
    public GameObject prefabExp;
}
