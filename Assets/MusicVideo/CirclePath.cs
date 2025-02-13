using UnityEngine;
public class CirclePath : MonoBehaviour
{
    GameObject circlePrefab;
    public float distance;
    public int numCircles;
    GameObject[] circles;
    public void Start()
    {
        circles = new GameObject[numCircles];
        for (int i = 0; i < circles.Length; i++)
        {
            circles[i] = Instantiate(circlePrefab, transform);
            circles[i].transform.localPosition = (Vector3.forward * distance / i);
        }
    }
    public void Update()
    {
        for (int i = 0; i < circles.Length; i++)
        {
            
        }
    }
}
