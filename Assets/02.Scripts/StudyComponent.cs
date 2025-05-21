using UnityEngine;

public class StudyComponent : MonoBehaviour {

    public GameObject Object;
    public string changeName;

    void Start() {
        Object = GameObject.Find("Main Camera");
        Object.name = changeName;
    }
}
