using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public bool playerActive;

    public float speed = 10;

    public float fireRate = 0.3f;
    private float nextFire = 0f;

    public int HP, killCount;
    public TMP_Text HPvis;

    public List<GameObject> bullets;

    public Animator animator;

    private bool canGetHit = true;

    public TMP_Text finalScore, finalKillCount, Score;

    public GameObject DeathUI;

    public List<GameObject> HealthBar;

    public SkillSpown skillSpown;

    public GameObject Shield;

    public GameObject impulseWave;

    void Awake()
    {
        HP = 5;
        killCount = 0;
        getHealth(HP);

        foreach (GameObject bullet in bullets)
        {
            bullet.SetActive(true);
        }
    }

    void Update()
    {
        if (playerActive == true)
        {
            Movement();
            FaceMouse();
            Fire();
            SkillsCheck();
            if (Shield.activeSelf == true)
            {
                Shield.transform.position = transform.position;
            }
        }

    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime);
        }

    }

    private void FaceMouse()
    {

        Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseWorldPosition - (Vector2)transform.position).normalized;
        transform.up = direction;

    }

    private void Fire()
    {

        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            foreach(GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    bullet.transform.parent = null;
                    break;
                }
            }

        }

    }

    private void SkillsCheck()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (skillSpown.ActiveSkills[0] != null)
            {
                if (skillSpown.ActiveSkills.Count != 0)
                {
                    SkillsUse(skillSpown.ActiveSkills[0]);
                    foreach (GameObject skill in skillSpown.NotActiveSkills)
                    {
                        if (skill.tag != "hp")
                        {
                            if (skill.GetComponent<SkillManager>().active == false && skill.tag == skillSpown.ActiveSkills[0].tag)
                            {
                                skill.GetComponent<SkillManager>().active = true;
                                break;
                            }
                        }
                    }
                    skillSpown.ActiveSkills[0].SetActive(false);
                    skillSpown.ActiveSkills[0] = null;
                    skillSpown.skillCount--;

                    if (skillSpown.ActiveSkills[1] != null)
                    {
                        skillSpown.ActiveSkills[0] = skillSpown.ActiveSkills[1];
                        skillSpown.ActiveSkills[1] = null;
                        skillSpown.ActiveSkills[0].transform.position = skillSpown.SkillSlot1.transform.position;
                    }
                    if (skillSpown.ActiveSkills[2] != null)
                    {
                        skillSpown.ActiveSkills[1] = skillSpown.ActiveSkills[2];
                        skillSpown.ActiveSkills[2] = null;
                        skillSpown.ActiveSkills[1].transform.position = skillSpown.SkillSlot2.transform.position;
                    }

                }
            }
        }
    }

    private void SkillsUse(GameObject skill)
    {
        if (skill.tag == "ShotWave")
        {
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 0);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 45);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 90);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 135);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 180);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 225);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 270);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
            foreach (GameObject bullet in bullets)
            {
                if (bullet.activeSelf == false)
                {
                    bullet.SetActive(true);
                    Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
                    bulletRB.velocity = Vector2.zero;
                    bullet.transform.parent = null;
                    bullet.transform.eulerAngles = new Vector3(0, 0, 315);
                    bulletRB.AddForce(bullet.transform.up * 0.05f);
                    break;
                }
            }
        }
        else if (skill.tag == "Shield")
        {
            StartCoroutine(ShieldSkill());
        }
        else if (skill.tag == "Impulse")
        {
            int layermask = (1 << 10) | (1 << 11) | (1 << 13);
            Vector2 explosionPos = transform.position;
            Collider2D[] colliders = Physics2D.OverlapCircleAll(explosionPos, 4f, layermask);
            foreach(Collider2D coll in colliders)
            {

                Rigidbody2D body = coll.gameObject.GetComponent<Rigidbody2D>();
                Vector3 explosionPosition = transform.position;
                float explosionRadius = 5f;
                float explosionForce = 100f;
                var dir = (body.transform.position - explosionPosition);
                float wearoff = 1 - (dir.magnitude / explosionRadius);
                body.AddForce(dir.normalized * explosionForce * wearoff);
                impulseWave.GetComponent<Animator>().Play("ImpulseWaveAnim", -1, 0f);
            }

        }
        else if (skill.tag == "Rocket")
        {

        }

    }


IEnumerator ShieldSkill()
    {
        Shield.SetActive(true);
        yield return new WaitForSeconds(7f);
        Shield.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 11 || collision.gameObject.layer == 16)
        {
            GetHit();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
            GetHit();
        }
    }

    public void GetHit()
    {
        if (canGetHit == true)
        {
            if (HP > 1)
            {
                StartCoroutine(getHitWait());
                HP = HP - 1;
                HPvis.text = "x" + HP.ToString();
                getHealth(HP);
            }
            else if (HP == 1)
            {
                HP = HP - 1;
                HPvis.text = "x" + HP.ToString();
                getHealth(HP);
                Die();
            }
        }
    }

    public void Die()
    {
        playerActive = false;
        DeathUI.SetActive(true);
        finalKillCount.text = killCount.ToString();
        finalScore.text = Score.text;
        Time.timeScale = 0;
    }

    IEnumerator getHitWait()
    {
        canGetHit = false;
        animator.Play("HitWait");
        yield return new WaitForSeconds(2.1f);
        animator.Play("BasePlayerAnim");
        canGetHit = true;
    }

    public void getHealth(int hpCount)
    {
        foreach(GameObject hpSegment in HealthBar)
        {
            hpSegment.SetActive(false);
        }
        for (int i = 0; i < hpCount; i++)
        {
            HealthBar[i].SetActive(true);
        }
    }


}

