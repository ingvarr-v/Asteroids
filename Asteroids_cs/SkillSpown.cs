using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSpown : MonoBehaviour
{
    public int skillCount = 0;

    public GameObject SkillSlot1, SkillSlot2, SkillSlot3;

    public List<GameObject> skills;

    public List<GameObject> ActiveSkills;

    public List<GameObject> NotActiveSkills;

    public int a;

    private bool skillCanSpown;


    void Start()
    {
        skillCanSpown = true;

        foreach (GameObject skill in skills)
        {
            skill.SetActive(false);
        }
        foreach (GameObject skill in NotActiveSkills)
        {
            skill.SetActive(false);
        }
    }

    void Update()
    {
        if (skillCanSpown)
        {
            StartCoroutine(skillSpownWait(5f));
        }
    }

    IEnumerator skillSpownWait(float time)
    {
        skillCanSpown = false;
        yield return new WaitForSeconds(time);
        Vector2 direction = (Vector2.zero - (Vector2)transform.position).normalized;
        int randomRotationOffset = Random.Range(-45, 45);
        transform.up = direction;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + randomRotationOffset);
        if (Random.Range(1, 3) == 1)
        {
            if (NotActiveSkills.Count != 0)
            {
                int randomSkill = Random.Range(0, NotActiveSkills.Count - 1);
                if (a != 0)
                {
                    randomSkill = a;
                }
                GameObject currentSkill = NotActiveSkills[randomSkill];
                if (currentSkill.tag != "hp")
                {
                    if (currentSkill.GetComponent<SkillManager>().active == true)
                    {
                        currentSkill.SetActive(true);
                        NotActiveSkills.Remove(currentSkill);
                        currentSkill.transform.parent = null;
                        currentSkill.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                        currentSkill.GetComponent<Rigidbody2D>().AddForce(transform.up * 0.01f);
                        currentSkill.transform.eulerAngles = Vector3.zero;
                    }
                }
                else
                {
                    currentSkill.SetActive(true);
                    NotActiveSkills.Remove(currentSkill);
                    currentSkill.transform.parent = null;
                    currentSkill.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    currentSkill.GetComponent<Rigidbody2D>().AddForce(transform.up * 0.01f);
                    currentSkill.transform.eulerAngles = Vector3.zero;
                }
            }
        }
        skillCanSpown = true;
    }
}
