using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;
    }

    private void Update()
    {
        transform.position += Ground.gameSpeed * Time.deltaTime * Vector3.left;
        if(gameObject.name == "Dino")
        {

        }
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }

}
