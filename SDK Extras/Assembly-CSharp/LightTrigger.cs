using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LightTrigger : MonoBehaviour
	{
		[SerializeField]
		[Header(null)]
		private LayerMask LayerFilter;

		[Header("Orginal Light Source")]
		[SerializeField]
		private Light SourceLight;

		[SerializeField]
		private GameObject SourceLightTransform;

		[SerializeField]
		[Header("Target Transformation")]
		public Transform TargetTransform;

		[SerializeField]
		[Header("Target Light properties")]
		[Range(0f, 180f)]
		private float SpotLightAngle;

		[SerializeField]
		private float LightRange;

		[SerializeField]
		private float LightIntensity;

		[SerializeField]
		private Color LightColor;

		[SerializeField]
		[HideInInspector]
		public float OverallTransitionTime;

		[SerializeField]
		[HideInInspector]
		public float outTransitionTime;

		[HideInInspector]
		[SerializeField]
		public float inTransitionTime;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void MoveLight()
		{
		}

		private void ChangeLightSettings()
		{
		}

		private IEnumerator LightTransition()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void MatchSettings()
		{
		}

		public void GrabChildTransform()
		{
		}

		public void AddChildTransform()
		{
		}

		public LightTrigger()
			: base()
		{
		}
	}
}
