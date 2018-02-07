
using UnityEngine;

public class enemySelfkill : MonoBehaviour {

    private float CurrentTime;

    private void Start()
    {
        CurrentTime = Time.time;
    }
    private void Update()
    {
        if (Time.time - CurrentTime > 5)
        {
            Destroy(gameObject);
        }
    }

}
