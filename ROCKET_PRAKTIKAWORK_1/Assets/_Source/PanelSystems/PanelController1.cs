using PlaySoundSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PanelSystems
{
    public class PanelController1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private GameObject visiblePanel;
        [SerializeField] private GameObject triggerPanel;

        void Start()
        {
            EventTrigger eventTrigger = triggerPanel.GetComponent<EventTrigger>();

            if (eventTrigger == null)
            {
                eventTrigger = triggerPanel.AddComponent<EventTrigger>();
            }

            EventTrigger.Entry entryEnter = new EventTrigger.Entry();
            entryEnter.eventID = EventTriggerType.PointerEnter;
            entryEnter.callback.AddListener((data) => { OnPointerEnter((PointerEventData)data); });

            EventTrigger.Entry entryExit = new EventTrigger.Entry();
            entryExit.eventID = EventTriggerType.PointerExit;
            entryExit.callback.AddListener((data) => { OnPointerExit((PointerEventData)data); });

            eventTrigger.triggers.Add(entryEnter);
            eventTrigger.triggers.Add(entryExit);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            visiblePanel.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            visiblePanel.SetActive(false);
        }
    }
}