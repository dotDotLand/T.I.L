using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;   // 이동 속도
    public float runSpeed = 8f;    // 달릴 때 속도
    public float stamina = 100f;   // 스태미나
    public float staminaDecrease = 10f; // 달릴 때 초당 감소량
    public float staminaRecover = 5f;   // 회복 속도

    public float hp = 100f;         // 체력
    public float maxHp = 100f;      // 최대 체력
    public bool isAlive = true;     // 생존 여부

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

        // 방향 입력
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize(); // 대각선 속도 보정

        // 달리기
        isRunning = Input.GetKey(KeyCode.LeftShift) && stamina > 0;

        // 스태미나 관리
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

    // 좀비와 충돌시 체력 감소
    public void TakeDamage(float damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            hp = 0;
            isAlive = false;
            Debug.Log("플레이어 사망");
        }
    }

}
