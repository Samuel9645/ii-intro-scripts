using UnityEngine;

public class Activity5 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {

  }

  // Update is called once per frame
  public void Update() {
    const int detectionPeriod = 30;
    if (Input.GetKey(KeyCode.Space) &&
        (Time.frameCount % detectionPeriod == 0)) {
      transform.position += Delta;
    }
  }

  public Vector3 Delta = new(0, 1, 0);

}
