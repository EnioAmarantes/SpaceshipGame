using UnityEngine;

public class scriptNPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    public int xp = 5;
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        vel = 5;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -Camera.main.orthographicSize)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("shoot"))
            scoreScript.scoreIncrement(xp);
        
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}
