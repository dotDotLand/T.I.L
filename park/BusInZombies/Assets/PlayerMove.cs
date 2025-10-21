using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;   // �̵� �ӵ�
    public float runSpeed = 8f;    // �޸� �� �ӵ�
    public float stamina = 100f;   // ���¹̳�
    public float staminaDecrease = 10f; // �޸� �� �ʴ� ���ҷ�
    public float staminaRecover = 5f;   // ȸ�� �ӵ�

    public float hp = 100f;         // ü��
    public float maxHp = 100f;      // �ִ� ü��
    public bool isAlive = true;     // ���� ����

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private bool isRunning;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isAlive) return;

        // ���� �Է�
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize(); // �밢�� �ӵ� ����

        // �޸���
        isRunning = Input.GetKey(KeyCode.LeftShift) && stamina > 0;

        // ���¹̳� ����
        if (isRunning)
            stamina -= staminaDecrease * Time.deltaTime;
        else
            stamina += staminaRecover * Time.deltaTime;

        stamina = Mathf.Clamp(stamina, 0, 100);
    }

    void FixedUpdate()
    {
        if (!isAlive) return;

        float currentSpeed = isRunning ? runSpeed : moveSpeed;
        rb.MovePosition(rb.position + moveInput * currentSpeed * Time.fixedDeltaTime);
    }

    // ����� �浹�� ü�� ����
    public void TakeDamage(float damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            hp = 0;
            isAlive = false;
            Debug.Log("�÷��̾� ���");
        }
    }

}
