using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float damage = 10f;
    public float detectRange = 5f; // �÷��̾ �ν��ϴ� �Ÿ�

    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (player == null) return;

        // �÷��̾���� �Ÿ� ���
        float distance = Vector2.Distance(transform.position, player.position);

        // �÷��̾ ���� �Ÿ� �ȿ� ������ ����
        if (distance < detectRange)
        {
            Vector2 dir = (player.position - transform.position).normalized;
            transform.position += (Vector3)dir * moveSpeed * Time.deltaTime;
        }
    }

    // �÷��̾� �浹 �� ü�� ���
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 1. �浹�� ������Ʈ�� �±װ� "Player"���� Ȯ��
        if (other.CompareTag("Player"))
        {
            PlayerMove pm = other.GetComponent<PlayerMove>();
            pm.TakeDamage(damage);
        }
    }
}