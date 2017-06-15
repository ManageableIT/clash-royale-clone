﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CRC
{
    public class Tower : Offensive
    {
        [SerializeField]
        private TextMeshProUGUI m_HPText;

        protected override void Awake()
        {
            base.Awake();

            m_CurrentHealth = m_MaxHealth;
            m_HPText.text = m_CurrentHealth.ToString();
        }

        protected virtual void Start()
        {
            HealthChangeEvent += OnHealthChange;
        }

        protected virtual void OnDestroy()
        {
            HealthChangeEvent -= OnHealthChange;
        }

        protected virtual void OnHealthChange()
        {
            m_HPText.text = m_CurrentHealth.ToString();
        }
    }
}
