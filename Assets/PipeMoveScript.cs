using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -30;

    // Update is called once per frame
    void Update()
    {
        if (LogicManagerScript.instance.gameOverScreen.activeSelf) return;
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }

    private void LateUpdate()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
