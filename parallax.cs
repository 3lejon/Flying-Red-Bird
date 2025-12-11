using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    public float animationspeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationspeed * Time.deltaTime, 0);
    }
}
