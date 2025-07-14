using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalPluck : MonoBehaviour
{
    [SerializeField] public Animator anim;
    [SerializeField] AudioClip flowerPop;
    Collider2D col;
    AudioSource audioSrc;


    private void Start()
    {
        col = GetComponent<Collider2D>();
        audioSrc = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (col == Physics2D.OverlapPoint(worldPoint)) 
            {
                if (anim) anim.SetBool("isplaying", true);
                StartCoroutine(PlayFlowerPop());
                StartCoroutine(DestroyAfterDelay());
            }
        }
    }
    IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(3.9f);
        Destroy(gameObject);
    }

    IEnumerator PlayFlowerPop()
    {
        audioSrc.PlayOneShot(flowerPop); 
        yield break; 
    }


}
