using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    [SerializeField] private GameObject boxPrefab;
    
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-10f, 10f);
            float z = Random.Range(-10f, 10f);
            Instantiate(boxPrefab, new Vector3(x, y, z), Quaternion.Euler(0, 0, 0));
        }
    }
}