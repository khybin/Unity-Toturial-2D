using UnityEngine;

public class Movement : MonoBehaviour {
    public float moveSpeed = 5f;

    void Update() {
        /** Input System (Old - Legacy)
            입력 값에 대한 약속된 시스템
            이동 -> WASD, 방향키
            점프 -> Space
            총쏘기  -> 마우스 좌클릭 **/

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Debug.Log($"현재 입력 : {direction}");

        transform.position += Time.deltaTime * moveSpeed * direction;
    }
}
