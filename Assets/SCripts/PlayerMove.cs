using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;  // 이동 속도 조절
    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 좌우 입력값 (-1: 왼쪽, 0: 정지, 1: 오른쪽)
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        // Rigidbody2D를 이용한 물리 기반 이동
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }
}
