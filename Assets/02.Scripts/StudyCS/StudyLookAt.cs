using UnityEngine;

public class StudyLookAt : MonoBehaviour {
    public Transform target;
    public Transform turretHead;

    public GameObject bulletPrefab;
    public Transform firePos;

    public float timer;
    public float cooldownTime;

    void Start() {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update() {
        turretHead.LookAt(target);

        timer += Time.deltaTime;
        if (timer >= cooldownTime) {
            timer = 0;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
