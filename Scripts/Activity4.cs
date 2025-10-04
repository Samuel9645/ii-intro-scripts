using UnityEngine;

public class Activity4 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {
    GameObject cube = FindGameObjectOrLogError("Cube");
    GameObject cylinder = FindGameObjectOrLogError("Cylinder");
    if (cube != null && cylinder != null) {
      ShowDistance(gameObject, cube);
      ShowDistance(gameObject, cylinder);
    }
  }

  // Update is called once per frame
  public void Update() {

  }

  private GameObject FindGameObjectOrLogError(string objectName) {
    GameObject foundObject = GameObject.Find(objectName);
    if (foundObject == null) {
      Debug.LogFormat("Error: {0} not found in scene", objectName);
    }
    return foundObject;
  }

  private void ShowDistance(GameObject object1, GameObject object2) {
    Debug.LogFormat(
      "Distance from {0} to {1} = {2}", object1.name, object2.name,
      Vector3.Distance(object1.transform.position, object2.transform.position)
    );
  }
}
