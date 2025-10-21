using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float damage = 10f;
    public float detectRange = 5f; // 플레이어를 인식하는 거리

    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        // 플레이어와의 거리 계산
        float distance = Vector2.Distance(transform.position, player.position);

        // 플레이어가 일정 거리 안에 있으면 추적
        if (distance < detectRange)
        {
            Vector2 dir = (player.position - transform.position).normalized;
            transform.position += (Vector3)dir * moveSpeed * Time.deltaTime;
        }
    }

    // 플레이어 충돌 시 체력 깎기
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 1. 충돌한 오브젝트의 태그가 "Player"인지 확인
        if (other.CompareTag("Player"))
        {
            PlayerMove pm = other.GetComponent<PlayerMove>();
            pm.TakeDamage(damage);
        }
    }
}