using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class Ground : MonoBehaviour
{
    public static float gameSpeed = 5f;
    //public float gameSpeedIncrease = 1;
    private MeshRenderer meshRenderer;
    float timer = 0f;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        gameSpeed = 5f;
        float timer = Time.time;
    }

    private void Update()
    {
        timer = Time.deltaTime/10;  // Increase timer over time
        gameSpeed += timer;
        //gameSpeedIncrease += time.deltaTime;
        float speed = gameSpeed / transform.localScale.x;
        meshRenderer.material.mainTextureOffset += speed * Time.deltaTime * Vector2.right;
    }
}
