using UnityEngine;

public class Activity8 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {

  }

  // Update is called once per frame
  public void Update() {
    const int detectionPeriod = 30;
    if (Time.frameCount % detectionPeriod == 0) {
      transform.Translate(MoveDirection * Speed);
    }
  }

  public Vector3 MoveDirection = new(0, 1, 0);
  public float Speed = 1.4f;
}
