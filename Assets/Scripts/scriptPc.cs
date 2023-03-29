using UnityEngine;

public class scriptPc : MonoBehaviour
{
    private float altura;
    private float largura;

    private Rigidbody2D rbd;
    public GameObject tiro;
    public float vel;
    private AudioSource som;
    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
        vel = 10;
        rbd = GetComponent<Rigidbody2D>();
        som = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x, y) * vel;

        if (transform.position.x > largura)
            transform.position = 
                  new Vector2(-largura,transform.position.y);
        else if(transform.position.x < -largura)
            transform.position =
                  new Vector2(largura, transform.position.y);

        if (transform.position.y > 0)
            transform.position =
                    new Vector2(transform.position.x, 0);
        else if(transform.position.y < -altura)
            transform.position =
                    new Vector2(transform.position.x, -altura);

            Atirar();

    }

    private void Atirar()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && !gameScript.pause)
        {
            som.Play();
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            float altura = sr.sprite.bounds.extents.y / 2;
            Vector2 pos = new Vector2(transform.position.x, transform.position.y + altura);
            Instantiate(tiro, pos, Quaternion.identity);
        }

    }
}
