using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Playerに向かって弾を発射する
public class EnemyShot : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Bullet bulletPref;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayerAimShot(3));
    }

    void Shot(Vector3 pos, float speed)
    {
        // 弾を生成する
        Bullet bullet = Instantiate(bulletPref, transform.position, transform.rotation);
        bullet.Setting(pos,speed);
    }

    IEnumerator PlayerAimShot(float speed)
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);

            if (player != null)
            {
                Vector3 targetPos = player.transform.position - transform.position;
                Shot(targetPos.normalized, speed);
            }
        }
    }
}
