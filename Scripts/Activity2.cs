using UnityEngine;

public class VectorData {

  public VectorData(string name, Vector3 vector) {
    Name = name;
    Vector = vector;
  }
  public string Name;
  public Vector3 Vector;
}
public class Activity2 : MonoBehaviour {
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void Start() {
    ShowVectorsData();
  }

  // Update is called once per frame
  public void Update() { }

  private void ShowVectorData(VectorData vectorInfo) {
    Debug.LogFormat(
      "{0} Vector => x component: {1}, " +
      "y component: {2},z component: {3}",
      vectorInfo.Name, vectorInfo.Vector.x,
      vectorInfo.Vector.y, vectorInfo.Vector.z
    );
  }
  public Vector3 FirstVector = new(0.0f, 1.0f, 1.0f);
  public Vector3 SecondVector = new(1.0f, 1.0f, 0.0f);
  private void LogVectorsRelativePosition(
    VectorData vector1,
    VectorData vector2,
    string relativePosition
  ) {
    Debug.LogFormat(
            "{0} Vector with position : {1} height is {4} than " +
            "{2} Vector with position : {3}",
            vector1.Name, vector1.Vector,
            vector2.Name, vector2.Vector, relativePosition
          );
  }

  private void ShowVectorsData() {
    const string firstVectorId = "First";
    const string secondVectorId = "Second";
    VectorData firstVectorData = new(firstVectorId, FirstVector);
    VectorData secondVectorData = new(secondVectorId, SecondVector);
    ShowVectorData(firstVectorData);
    ShowVectorData(secondVectorData);
    Debug.LogFormat(
      "Angle: {0}", Vector3.Angle(FirstVector, SecondVector)
    );
    Debug.LogFormat(
      "Distance: {0}", Vector3.Distance(FirstVector, SecondVector)
    );
    if (FirstVector.y > SecondVector.y) {
      LogVectorsRelativePosition(firstVectorData, secondVectorData, "higher");
    } else if (FirstVector.y < SecondVector.y) {
      LogVectorsRelativePosition(firstVectorData, secondVectorData, "lower");
    } else {
      LogVectorsRelativePosition(firstVectorData, secondVectorData, "equal");
    }
  }

}
