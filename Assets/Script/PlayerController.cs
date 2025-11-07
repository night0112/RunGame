using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;     //左右移動速度
    [SerializeField] private float forwardSpeed = 10f; //前進速度

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        //左右移動
        transform.Translate(Vector3.right * horizontal * moveSpeed * Time.deltaTime);

        //自動前進
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        
    }

    //当たり判定
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Laser"))
        {
            Debug.Log("ゲームオーバー！");
            SceneManager.LoadScene("ResultScene"); // リトライ
        }
    }
}
