using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    [SerializeField] private GameObject boxPrefab;
    
    void Start()
    {
        Instantiate(boxPrefab, new Vector3(-5, 5, 0), Quaternion.Euler(30, 0, 0));
        Instantiate(boxPrefab, new Vector3( 0, 5, 0), Quaternion.Euler(45, 0, 0));
        Instantiate(boxPrefab, new Vector3( 5, 5, 0), Quaternion.Euler(60, 0, 0));
    }
}
