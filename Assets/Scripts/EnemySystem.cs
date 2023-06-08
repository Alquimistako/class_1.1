using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.Find("���Z").transform;
    }

    [Header("�ͩR��"), Range(0, 1000)]
    public float HP;
    [Header("�����O"), Range(0, 1000)]
    public float AP;
    [Header("�]�t"), Range(0, 10)]
    public float SP;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.01f);
    }
}
