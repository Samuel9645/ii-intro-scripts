using UnityEngine;
using UnityEngine.UIElements;

public class Activity12 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {
    _sphere = FindGameObjectOrLogError("Sphere");
    if (_sphere == null) {
      return;
    }
    Vector3 newPosition = transform.position;
    newPosition.y = _sphere.transform.position.y;
    transform.position = newPosition;

  }

  // Update is called once per frame
  public void Update() {
    if (_sphere == null || _sphere.transform.position == transform.position) {
      return;
    }
    transform.LookAt(_sphere.transform);
    _angle += Speed * Time.deltaTime;
    const double maxRads = 2 * Mathf.PI;
    if (_angle >= maxRads) {
      _angle = 0;
    }
    Vector3 orbit = new(Mathf.Sin(_angle), 0, Mathf.Cos(_angle));
    transform.position = _sphere.transform.position +
      orbit * OrbitDistance;
  }

  public float Speed = 1.2f;
  public float OrbitDistance = 5f;

  private GameObject _sphere;
  private float _angle;

  private GameObject FindGameObjectOrLogError(string objectName) {
    GameObject foundObject = GameObject.Find(objectName);
    if (foundObject == null) {
      Debug.LogFormat("Error: {0} not found in scene", objectName);
    }
    return foundObject;
  }
}
