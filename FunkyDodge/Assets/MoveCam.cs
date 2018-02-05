using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public float speed = 10.0f;
    //public GameObject Player;
    
    void Start()
    {
        Debug.Log("Start() called.");
    }

    void Update()
    {
        var dx = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        var dz = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;
        transform.Translate(new Vector3(dx, dz, 0));

        /*
        var Ptran = Player.transform.position;
        transform.position = Ptran + new Vector3(0, 30, 0);
    */
    }
}