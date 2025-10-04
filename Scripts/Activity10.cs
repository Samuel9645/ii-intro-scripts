using UnityEngine;

public class Activity10 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {

  }

  // Update is called once per frame
  public void Update() {
    float horizontalAxis = Input.GetAxis("Horizontal");
    float verticalAxis = Input.GetAxis("Vertical");
    Vector3 direction = new(horizontalAxis, verticalAxis);
    transform.Translate(Speed * Time.deltaTime * direction);
  }
  public float Speed = 1;
}
