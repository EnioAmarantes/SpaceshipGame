using UnityEngine;

public class fundoScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rbd;
    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -speed);
    }

    void Update()
    {
        if (transform.position.y < -Camera.main.orthographicSize*2)
            rbd.position = new Vector2(0, 10);
    }

}
