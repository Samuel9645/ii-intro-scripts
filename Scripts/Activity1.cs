using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Activity1 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {
    _renderer = GetComponent<Renderer>();
    _material = _renderer.material;
  }

  // Update is called once per frame
  public void Update() {
    if (FramesUntilUpdate <= 0) {
      const int messageFramePeriod = 5000;
      if (FramePeriodPassed(messageFramePeriod)) {
        Debug.Log("Invalid value, FramesUntilUpdate must be bigger than 0");
      }
      return;
    }
    if (FramePeriodPassed(FramesUntilUpdate)) {
      ChangeColor();
      ChangePosition();
    }
  }
  public int FramesUntilUpdate = 20;
  private Vector3 _currentColor;
  private Renderer _renderer;
  private Material _material;

  private bool FramePeriodPassed(int framesToWait) {
    return (Time.frameCount % framesToWait) == 0;
  }

  private int GetRandomIndex() {
    const int vectorSize = 3;
    return Random.Range(0, vectorSize);
  }

  private void ChangeColor() {
    int randomIndex = GetRandomIndex();
    _currentColor[randomIndex] = Random.value;
    _material.color = new Color(
      _currentColor[0],
      _currentColor[1],
      _currentColor[2]
    );
  }

  private void ChangePosition() {
    int randomIndex = GetRandomIndex();
    Vector3 newPosition = transform.position;
    newPosition[randomIndex] = Random.value;
    transform.position = newPosition;
  }

}
