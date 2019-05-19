using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset = new Vector3(0, 2, -6);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
