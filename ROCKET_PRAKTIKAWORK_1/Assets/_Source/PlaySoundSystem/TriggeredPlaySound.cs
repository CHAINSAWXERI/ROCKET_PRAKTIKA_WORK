using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlaySoundSystem
{
    public class TriggeredPlaySound : MonoBehaviour
    {
        [SerializeField] private GameObject triggerPanel;
        [SerializeField] private OneShotPlaySound oneSHotPlaySound;
        [SerializeField] private AudioClip audioClip;

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

            eventTrigger.triggers.Add(entryEnter);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            oneSHotPlaySound.PlaySound(audioClip);
        }
    }
}