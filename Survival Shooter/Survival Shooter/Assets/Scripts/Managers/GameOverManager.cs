using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;

    public PlayerHealth playerHealth;
    public float restartDelay = 5f;

    public bool isOver = false;


    Animator anim;
    float restartTimer;


    void Awake()
    {
        anim = GetComponent<Animator>();
        isOver = true;
    }

    void Update()
    {
        
        if (playerHealth.currentHealth <= 0 && isOver == true)
        {
              
            anim.SetTrigger("GameOver");
            
            Debug.Log("isover: " + isOver);
            Debug.Log("nyawa: " + playerHealth.currentHealth);

            //
            restartTimer += Time.deltaTime;


            //
            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        }
    }

    public void ShowWarning(float enemyDistance)
    {
        
        //
        warningText.text = string.Format("! {0} m", Mathf.RoundToInt(enemyDistance));

        anim.SetTrigger("Warning");
    }
}