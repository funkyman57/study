
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject cubePrefab;
    public GameObject Player;
    public Material purpleMaterial;
    public float r = 25.0f;
    public float LastLogTime { get; private set; }
    public float speed = 10.0f;
    
    void Start () {
        Debug.Log("Start() called.");
    }

    void Update () {



        var theta = Random.Range(0, 2 * Mathf.PI);
        var v1 = Mathf.Sin(theta);
        var v2 = Mathf.Cos(theta);

        if (Time.time - LastLogTime > 0.5f)
        {
            var enemy = Instantiate(cubePrefab, transform);
            var te = enemy.transform;
            te.GetComponent<MeshRenderer>().material = purpleMaterial;
            te.transform.position = Player.transform.position + new Vector3(r * v2, 0.5f, r * v1);
            te.localScale = new Vector3(Random.Range(1,5), Random.Range(1, 5), Random.Range(1, 5));
            enemy.GetComponent<enemyCollision>().playerHp = Player.GetComponent<PlayerHP>();
            LastLogTime = Time.time;
        }
	}
}
