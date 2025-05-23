using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour {

    public GameObject prefab;

    public GameObject destroyObject;
    public float destroyTime;

    public Vector3 position;
    public Quaternion rotation;

    void Awake() {
        CreateAmongUs();
    }

    public void CreateAmongUs() {
        GameObject Object = Instantiate(prefab, position, rotation);
        Object.name = "AmoungUs";

    }
}
