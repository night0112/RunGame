using UnityEngine;

public class LaserDel : MonoBehaviour
{
    float delTime = 5.0f;
  
    void Update()
    {
        Destroy(gameObject,delTime);
    }
}
