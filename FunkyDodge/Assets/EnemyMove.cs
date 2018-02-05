using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public GameObject player;
    public float speed = 0.1f;

    void Start()
    {
        player = GameObject.Find("Player1");
    }

    private void Update () {
        Vector3 diff = player.transform.position - transform.position;
        Vector3 dir = diff.normalized;
        transform.Translate(diff * speed * Time.deltaTime);
	}
}
