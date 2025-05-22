using UnityEngine;

public class Movement : MonoBehaviour {
    public float moveSpeed = 5f;

    void Update() {
        /** Input System (Old - Legacy)
            �Է� ���� ���� ��ӵ� �ý���
            �̵� -> WASD, ����Ű
            ���� -> Space
            �ѽ��  -> ���콺 ��Ŭ�� **/

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Debug.Log($"���� �Է� : {direction}");

        transform.position += Time.deltaTime * moveSpeed * direction;
    }
}
