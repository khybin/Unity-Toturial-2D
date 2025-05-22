using UnityEngine;

public class StudyComponent : MonoBehaviour {

    public GameObject Object;

    public Mesh mesh;
    public Material material;

    void Start() {
        //Object = GameObject.CreatePrimitive(PrimitiveType.Cube);
        CreateCube();
    }

    public void CreateCube(string name = "Cube") {
        Object = new GameObject(name);

        Object.AddComponent<MeshFilter>();
        Object.GetComponent<MeshFilter>().mesh = mesh;

        Object.AddComponent<MeshRenderer>();
        Object.GetComponent<MeshRenderer>().material = material;

        Object.AddComponent<BoxCollider>();
    }
}
