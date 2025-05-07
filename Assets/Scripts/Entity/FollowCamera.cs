using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    float offsetX;
    float offsetY;

    void Start()
    {
        if (target == null)
            return;

        offsetX = transform.position.x - target.position.x;
    }

    void Update()
    {
        if (target == null)
            return;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(target.position.x + offsetX, -3.65f ,3.65f); // 바로 x값을 넣지 말고 새로 변수를 만들어서 대입할 것
        pos.y = Mathf.Clamp(target.position.y + offsetY, -2f, 2f);
        transform.position = pos;
    }
}
