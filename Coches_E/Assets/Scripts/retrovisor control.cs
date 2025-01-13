using UnityEngine;

public class retrovisorcontrol : MonoBehaviour
{
    [SerializeField] GameObject retrovisor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            retrovisor.SetActive(true);
        }

    if (Input.GetKeyUp(KeyCode.R)){
        retrovisor.SetActive(false);
    }
    }
}
