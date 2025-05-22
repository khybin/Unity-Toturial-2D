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

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {transform.childCount}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {transform.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {transform.GetChild(Object.transform.childCount - 1).name}");
    }
}
