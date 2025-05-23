using UnityEngine;

public class Movement : MonoBehaviour {
    public float moveSpeed = 5f;

    void Update() {
        /* ------ �ε巴�� ���� ( ����, ���� ) ------ */
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");

        /* ------ �� �������� �� ( ����, ��Ÿ��� ) ------ */
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized; //����ȭ ����

        //Debug.Log($"���� �Է� : {dir}");

        //transform.position += dir * moveSpeed * Time.deltaTime;
        transform.position += normalDir * moveSpeed * Time.deltaTime;
    }
}