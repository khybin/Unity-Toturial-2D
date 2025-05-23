using UnityEngine;

public class Movement : MonoBehaviour {
    public float moveSpeed = 5f;

    void Update() {
        /* ------ 부드럽게 증가 ( 관성, 느림 ) ------ */
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");

        /* ------ 딱 떨어지는 값 ( 빠름, 피타고라스 ) ------ */
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized; //정규화 과정

        //Debug.Log($"현재 입력 : {dir}");

        //transform.position += dir * moveSpeed * Time.deltaTime;
        transform.position += normalDir * moveSpeed * Time.deltaTime;
    }
}