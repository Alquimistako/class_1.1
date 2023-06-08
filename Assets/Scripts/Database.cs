using UnityEngine;

[CreateAssetMenu(menuName = "Data/base")]
public class Database : ScriptableObject
{
    [Header("�ͩR��"), Range (0,1000)]
    public float HP; 
    [Header("�����O"), Range (0,1000)]
    public float AP;
    [Header("�]�t"), Range (0,100)]
    public float SP;

}
