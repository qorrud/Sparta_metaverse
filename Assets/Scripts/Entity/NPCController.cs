using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    protected Rigidbody2D _npcRigidbody;
    [SerializeField] private SpriteRenderer npcRenderer;
    [SerializeField] private GameObject interactionPopup;

    public GameObject ExplainUI;
    bool isPlayerEncounter = false;
    

    protected virtual void Awake()
    {
        _npcRigidbody = GetComponent<Rigidbody2D>();

    }

    protected void Update()
    {
        if(isPlayerEncounter && Input.GetKeyDown(KeyCode.F))
        {
            ExplainUI.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerEncounter = true;
            interactionPopup.SetActive(true);//f를 눌러 대화하기 팝업 보여주기
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPopup.SetActive(false); // 플레이어가 벗어나면 팝업 숨김
            isPlayerEncounter = false;
            ExplainUI.SetActive(false);
        }
    }
}
