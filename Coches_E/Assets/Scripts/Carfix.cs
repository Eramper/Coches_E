using UnityEngine;

public class Carfix : MonoBehaviour
{
    void Start()
    {
        transform.position = transform.parent.position;
    }

    void Update()
    {
        
    }
}
