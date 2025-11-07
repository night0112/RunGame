using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] private ParticleSystem confettiParticles;
    private bool reached = false;

    private void OnTriggerEnter(Collider other)
    {
        if (reached) return;

        if (other.CompareTag("Player"))
        {
            reached = true;

            //パーティクル再生
            if (confettiParticles != null)
                Instantiate(confettiParticles,transform.position,Quaternion.identity);

            Debug.Log("ゴール！おめでとう！");

            //1秒後にシーン遷移
            Invoke(nameof(GoNextScene), 1f);
        }
    }

    private void GoNextScene()
    {
        //次のシーンに移動する場合はここを変更
        SceneManager.LoadScene("TitleScene");
    }
}
