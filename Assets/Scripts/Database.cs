using UnityEngine;

[CreateAssetMenu(menuName = "Data/base")]
public class Database : ScriptableObject
{
    [Header("生命值"), Range (0,1000)]
    public float HP; 
    [Header("攻擊力"), Range (0,1000)]
    public float AP;
    [Header("跑速"), Range (0,100)]
    public float SP;

}
