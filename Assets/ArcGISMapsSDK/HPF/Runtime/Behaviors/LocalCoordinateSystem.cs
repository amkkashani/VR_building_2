﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Esri.HPFramework
{

    /// <summary>
    /// The LocalCoordinateSystem component causes any HPTransform to be defined as 
    /// the center of interest within the universe space. This will maximize rendering
    /// precision around this object by essentially keeping it in the center of the
    /// scene. For many applications, the camera or the player makes for a good candidate
    /// as the origin HPTransform.
    /// 
    /// This component is meant as an example of how to implement a very simple dynamic
    /// rebasing scheme. However, many other schemes can and should be considered, such
    /// as rebasing only when getting a predefined distance from the origin or event triggered
    /// rebasing when the user performs an action.
    /// </summary>
    [RequireComponent(typeof(HPRoot))]
    public class LocalCoordinateSystem : MonoBehaviour
    {
        /// <summary>
        /// The object who's position and rotation will correspond to the origin
        /// of the scene. It's position, in world space will be zero, and it's 
        /// rotation will be identity.
        /// </summary>
        [SerializeField]
        private HPTransform m_Origin;

        private HPRoot m_Root;

        private DVector3 m_LastPosition;

        private void Start()
        {
            m_Root = GetComponent<HPRoot>();
        }

        void LateUpdate()
        {
            if (m_Origin != null && m_LastPosition != m_Origin.DUniversePosition)
            {
                m_LastPosition = m_Origin.DUniversePosition;
                m_Root.DRootUniversePosition = m_LastPosition;
            }
        }
    }
}