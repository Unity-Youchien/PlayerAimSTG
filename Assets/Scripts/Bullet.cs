using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float dx;
    float dy;

    public void Setting(Vector3 pos, float speed)
    {
        dx = pos.x * speed;
        dy = pos.y * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(dx, dy, 0) * Time.deltaTime;
    }
}
