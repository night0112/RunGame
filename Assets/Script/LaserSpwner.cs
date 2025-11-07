using UnityEngine;

public class LaserSpwner : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;  
    [SerializeField] private Transform player;         
    [SerializeField] private Transform goal;   
    
    private float spawnInterval = 2.0f;  //出現間隔
    private float laneWidth = 3f;        //横方向の範囲
    private float forwardDistance = 10f;  //前方距離
    private float forwardRange = 10f;     //ランダム範囲
    private float yPosition = 0.5f;      //出現高さ

    private void Start()
    {
        InvokeRepeating(nameof(SpawnLaser), 1f, spawnInterval);
    }

    private void SpawnLaser()
    {
        if (laserPrefab == null || player == null || goal == null) return;

        //横位置ランダム
        float xPos = Random.Range(-laneWidth, laneWidth);

        //Z方向ランダム
        float zOffset = Random.Range(forwardDistance - forwardRange, forwardDistance + forwardRange);
        float zPos = player.position.z + zOffset;

        //ゴールより先に出ないよう制限
        if (zPos > goal.position.z - 5f) 
        {
            zPos = goal.position.z - 5f;
        }

        //出現位置を確定
        Vector3 spawnPos = new Vector3(xPos, yPosition, zPos);

        //障害物を生成
        Instantiate(laserPrefab, spawnPos, Quaternion.identity);
    }
}
