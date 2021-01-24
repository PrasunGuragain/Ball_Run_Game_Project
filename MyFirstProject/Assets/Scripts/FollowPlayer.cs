using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Players position
    public Transform player;

    public Vector3 offset; // Camara view of player

    // Update is called once per frame
    public void Update()
    {
        // Follows player with offset
        transform.position = player.position + offset; 
    }
}
