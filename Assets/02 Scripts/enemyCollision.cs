using UnityEngine;

public class enemyCollision : MonoBehaviour
{

    public PlayerHP playerHp;
    private void OnTriggerEnter(Collider other)
    {
        playerHp.hp--;
        Destroy(gameObject);
        /* if(other.gameObject.name == " " 
         * if(other.tag == "")
         * if(other.GetComponent<EnemyMove>()
         * */
    }
}
