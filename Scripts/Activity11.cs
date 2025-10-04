using UnityEngine;

public class Activity11 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {
    _cube = FindGameObjectOrLogError("Cube");
  }

  // Update is called once per frame
  public void Update() {
    if (_cube == null || _cube.transform.position == transform.position) {
      return;
    }
    Vector3 direction = _cube.transform.position - transform.position;
    transform.Translate(Time.deltaTime * Speed * direction.normalized);
  }

  public float Speed = 1.2f;

  private GameObject _cube;

  private GameObject FindGameObjectOrLogError(string objectName) {
    GameObject foundObject = GameObject.Find(objectName);
    if (foundObject == null) {
      Debug.LogFormat("Error: {0} not found in scene", objectName);
    }
    return foundObject;
  }
}
