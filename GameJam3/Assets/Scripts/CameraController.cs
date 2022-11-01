using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;

    private Vector3 targetPosition;

    public float yOffset;
    public float xOffset;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        targetPosition = new Vector3(player.transform.position.x + xOffset,player.transform.position.y + yOffset,transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
