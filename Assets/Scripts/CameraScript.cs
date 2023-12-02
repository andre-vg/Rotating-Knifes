using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    // public Vector2 offset = new Vector2(0.0f, 0.0f);

    [Range(0.1f, 5.0f)]
    public float lerpSpeed = 0.5f;
    [Range(1f, 5.0f)]
    public float catchUpDistance = 3f;
    [Range(1f, 10.0f)]
    public float catchUpSpeed = 2f;

    private void LateUpdate()
    {
        float _lerpSpeed = lerpSpeed;

        if (Vector3. Distance(transform.position, player.transform.position) > catchUpDistance)
        {
            _lerpSpeed *= catchUpSpeed;
            transform.position = Vector2.Lerp(transform.position, player.transform.position, Time.deltaTime * _lerpSpeed);
        }

    }
}
