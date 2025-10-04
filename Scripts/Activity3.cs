using UnityEngine;

public class Activity3 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {
    LogCurrentPosition();
  }

  // Update is called once per frame
  public void Update() {

  }

  private void LogCurrentPosition() {
    Debug.LogFormat(
      "Current sphere position : {0}", transform.position
    );
  }
}
