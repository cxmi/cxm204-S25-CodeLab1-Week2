using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public float cameraDistance = -20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - cameraDistance);
    }
}
