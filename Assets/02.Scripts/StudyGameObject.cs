using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour {

    public GameObject prefab;

    public GameObject destroyObject;
    public float destroyTime;

    public Vector3 position;
    public Quaternion rotation;

    void Start() {
        CreateAmongUs();
    }

    public void CreateAmongUs() {
        GameObject Object = Instantiate(prefab, position, rotation);
        Object.name = "AmoungUs";

        Transform transform = Object.transform;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {transform.childCount}");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {transform.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {transform.GetChild(Object.transform.childCount - 1).name}");
    }
}
