using UnityEngine;

public class Activity9 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {

  }

  // Update is called once per frame
  public void Update() {
    const int detectionPeriod = 30;
    if (Time.frameCount % detectionPeriod == 0) {
      float horizontalAxis = Input.GetAxis("Horizontal");
      float verticalAxis = Input.GetAxis("Vertical");
      Vector3 direction = new(horizontalAxis, verticalAxis);
      transform.Translate(direction * Speed);
    }
  }
  public float Speed = 1;

}
