using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.Find("企鵝").transform;
    }

    [Header("生命值"), Range(0, 1000)]
    public float HP;
    [Header("攻擊力"), Range(0, 1000)]
    public float AP;
    [Header("跑速"), Range(0, 10)]
    public float SP;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.01f);
    }
}
