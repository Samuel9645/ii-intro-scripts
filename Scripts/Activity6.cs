using UnityEngine;

public class Activity6 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {

  }

  // Update is called once per frame
  public void Update() {
    const int detectionPeriod = 30;
    if (Time.frameCount % detectionPeriod == 0) {
      float horizontalAxis = Input.GetAxis("Horizontal");
      float verticalAxis = Input.GetAxis("Vertical");
      LogKeyPress(horizontalAxis, "Right", "Left");
      LogKeyPress(verticalAxis, "Up", "Down");
      Vector3 newPosition = transform.position;
      newPosition.x += Velocity * horizontalAxis;
      newPosition.y += Velocity * verticalAxis;
      transform.position = newPosition;
    }
  }

  public float Velocity = 1;

  private void LogKeyPress(
    float axis, string positiveValueMeaning,
    string negativeValueMeaning
    ) {
    const string baseMessage = "Arrow pressed";
    if (axis > 0) {
      Debug.LogFormat("{0} {1}", positiveValueMeaning, baseMessage);
    } else if (axis < 0) {
      Debug.LogFormat("{0} {1}", negativeValueMeaning, baseMessage);
    }
  }

}
