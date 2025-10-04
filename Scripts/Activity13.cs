using UnityEngine;

public class Activity13 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {

  }

  // Update is called once per frame
  public void Update() {
    float horizontalAxis = Input.GetAxis("Horizontal");
    Vector3 direction = new(0, horizontalAxis, 0);
    float adjustedSpeed = Time.deltaTime * Speed;
    const float rayLength = 500f;
    Debug.DrawRay(
      transform.position, transform.forward * rayLength, Color.red
    );
    transform.Rotate(Time.deltaTime * RotationSpeed * direction);
    transform.position += transform.forward * adjustedSpeed;
  }

  public float Speed = 1;
  public float RotationSpeed = 90f;

}
