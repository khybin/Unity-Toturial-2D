using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    void Update() {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }
}
