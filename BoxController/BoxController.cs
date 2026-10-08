using UnityEngine;

public class BoxController : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y <= -10f)
        {
            Destroy(gameObject);
        }
    }
}
