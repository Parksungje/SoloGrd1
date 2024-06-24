using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] GameObject failUI;
    private Rigidbody2D rigid;
    private GameManager gm;
    public int enemyCount;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Prisoner"))
        {
            Destroy(gameObject);
            failUI.SetActive(true);
            SceneManager.LoadScene("GameStart");

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            enemyCount++;
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Finish")
        {
            if (gm.totalEnemyCount == enemyCount)
            {
                gm.stage++;
                SceneManager.LoadScene("Stage2" + gm.stage);
            }
            else
            {
                SceneManager.LoadScene("Stage1" + gm.stage);
            }
        }

    }
}
