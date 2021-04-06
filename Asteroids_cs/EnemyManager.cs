using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyManager : MonoBehaviour
{
    public float speed = 10;

    //[HideInInspector]
    public bool ActiveEnemie = false;

    public float RotationSpeed=5f;

    private Rigidbody2D rb;

    public GameObject Player;
    public PlayerManager playerMan;

    public float HP, primeHP, HPbarScale;

    public GameObject hpBar;

    public GameObject Spown;

    public List<GameObject> bullets;

    public TMP_Text score, alienKills;

    private float nextFire = 0f, fireRate = 0.1f;

    public bool canFire=false;

    void Awake()
    {
        canFire = false;

        Spown = gameObject.transform.parent.gameObject;

        rb = GetComponent<Rigidbody2D>();
        if (gameObject.name.Contains("AlienShip1"))
        {
            primeHP = HP = 2;
            HPbarScale = 3.5f;
            speed = 30;
        }
        else if (gameObject.name.Contains("AlienShip2"))
        {
            primeHP = HP = 3;
            HPbarScale = 4.5f;
            speed = 23;
        }
        else if (gameObject.name.Contains("AlienShip3"))
        {
            primeHP = HP = 4;
            HPbarScale = 5.5f;
            speed = 17;
        }
        else if (gameObject.name.Contains("AlienShip4"))
        {
            primeHP = HP = 5;
            HPbarScale = 7f;
        }

        foreach (GameObject bullet in bullets)
        {
            bullet.SetActive(true);
        }       
    }

    void Update()
    {
        if (ActiveEnemie == true)
        {
            Vector2 PlayerWorldPos = Player.transform.position;
            Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
            
            rb.AddForce(direction* speed * Time.deltaTime);

            Vector2 pos = gameObject.transform.position;

            if (transform.position.x < 8.3f && transform.position.x > -8.3f && transform.position.y < 5.2f && transform.position.y > -5.2f) 
            {
                canFire = true;
            }
            else
            {
                canFire = false;
            }

            if (canFire == true)
            {
                if (gameObject.name.Contains("AlienShip1"))
                {
                    Fire1();
                }
                else if (gameObject.name.Contains("AlienShip2"))
                {
                    Fire2();
                }
                else if (gameObject.name.Contains("AlienShip3"))
                {
                    Fire3();
                }
                else if (gameObject.name.Contains("AlienShip4"))
                {
                    Fire4();
                }
            }
        }
    }

    public void Die()
    {
        HP = primeHP;
        hpBar.transform.localScale = new Vector3(1, HPbarScale, 1);
        Spown.GetComponent<EnemySpawn>().NotActiveEnemy.Add(gameObject);
        gameObject.transform.parent = Spown.transform;
        gameObject.transform.localPosition = Vector3.zero;
        Spown.GetComponent<EnemySpawn>().enemyCount -= 1; ;

        ScoreAdd();

        gameObject.SetActive(false);
    }

    private void ScoreAdd()
    {
        playerMan.killCount++;
        alienKills.text = "x" + (playerMan.killCount).ToString();
        if (gameObject.name.Contains("AlienShip1"))
        {
            int currentScore = int.Parse(score.text) + 20;
            int currentScoreSympolCount = currentScore.ToString().Length;
            score.text = "";
            for (int i = 0; i < 6 - currentScoreSympolCount; i++)
            {
                score.text = score.text + "0";
            }
            score.text = score.text + currentScore.ToString();
        }
        else if (gameObject.name.Contains("AlienShip2"))
        {
            int currentScore = int.Parse(score.text) + 25;
            int currentScoreSympolCount = currentScore.ToString().Length;
            score.text = "";
            for (int i = 0; i < 6 - currentScoreSympolCount; i++)
            {
                score.text = score.text + "0";
            }
            score.text = score.text + currentScore.ToString();
        }
        else if (gameObject.name.Contains("AlienShip3"))
        {
            int currentScore = int.Parse(score.text) + 30;
            int currentScoreSympolCount = currentScore.ToString().Length;
            score.text = "";
            for (int i = 0; i < 6 - currentScoreSympolCount; i++)
            {
                score.text = score.text + "0";
            }
            score.text = score.text + currentScore.ToString();
        }
        else if (gameObject.name.Contains("AlienShip4"))
        {
            int currentScore = int.Parse(score.text) + 35;
            int currentScoreSympolCount = currentScore.ToString().Length;
            score.text = "";
            for (int i = 0; i < 6 - currentScoreSympolCount; i++)
            {
                score.text = score.text + "0";
            }
            score.text = score.text + currentScore.ToString();
        }
    }

    private void Fire1()
    {
        if (Time.time > nextFire)
        {
            float randomFireRate = Random.Range(100,250);
            randomFireRate = randomFireRate / 100;
            nextFire = Time.time + randomFireRate;

            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bulletRB.AddForce(bullet.transform.up * 0.05f);                    
                    break;
                }
            }
        }
    }
    private void Fire2()
    {
        if (Time.time > nextFire)
        {
            float randomFireRate = Random.Range(200, 400);
            randomFireRate = randomFireRate / 100;
            nextFire = Time.time + randomFireRate;

            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z + 20);
                    bulletRB.AddRelativeForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z - 20f);
                    bulletRB.AddRelativeForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
        }
    }
    private void Fire3()
    {
        if (Time.time > nextFire)
        {
            float randomFireRate = Random.Range(200, 400);
            randomFireRate = randomFireRate / 100;
            nextFire = Time.time + randomFireRate;

            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z + 20);
                    bulletRB.AddForce(bullet.transform.up * 0.03f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z - 20);
                    bulletRB.AddForce(bullet.transform.up * 0.03f);
                    break;
                }
            }
        }
    }
    private void Fire4()
    {
        if (Time.time > nextFire)
        {
            float randomFireRate = Random.Range(250, 450);
            randomFireRate = randomFireRate / 100;
            nextFire = Time.time + randomFireRate;

            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z);
                    bulletRB.AddForce(bullet.transform.up * 0.03f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z - 90);
                    bulletRB.AddForce(bullet.transform.up * 0.03f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z + 90);
                    bulletRB.AddForce(bullet.transform.up * 0.03f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    bullet.transform.parent = null;
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    Vector2 PlayerWorldPos = Player.transform.position;
                    Vector2 direction = (PlayerWorldPos - (Vector2)transform.position).normalized;
                    bullet.transform.up = direction;
                    bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x,
                                                                bullet.transform.eulerAngles.y,
                                                                bullet.transform.eulerAngles.z - 180);
                    bulletRB.AddForce(bullet.transform.up * 0.03f);
                    break;
                }
            }
        }
    }

}
