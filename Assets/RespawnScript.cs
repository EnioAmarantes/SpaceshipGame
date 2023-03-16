using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    private readonly float _startPosition = 6;
    private float altura;
    public GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize * Camera.main.aspect;
        InvokeRepeating("Respawn", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Respawn()
    {
        float positionX = Random.Range(-altura, altura);
        Vector2 position = new Vector2(positionX, _startPosition);
        Instantiate(npc, position, Quaternion.identity);
    }
}
