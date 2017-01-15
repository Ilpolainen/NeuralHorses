﻿using UnityEngine;
using System.Collections;
namespace Code {

	public class Mind : MonoBehaviour {

		public NeuralNet neuralnet;
		private Steerable steerable;
		public int[] structure;
		public bool ready;
		public int id;
	// Use this for initialization
		void Start () {
			steerable = this.gameObject.GetComponent<Steerable> ();
		}
	
	// Update is called once per frame
		void FixedUpdate () {
			if (ready) {
				//	if (id == 0) {
				//		Debug.Log (neuralnet.GiveOutput (steerable.GetPositionInfo())[0]);
				//Debug.Log (neuralnet.id);
				//Debug.Log (neuralnet.id);
				//		}
				//Debug.Log ("STEERING!");
				steerable.Steer (neuralnet.GiveOutput (steerable.GetPositionInfo ()), 200);
			}
		}
			

		public void SetNeuralNet(NeuralNet net) {
			this.neuralnet = net;
		}
	
		public void SetSteerable(Steerable steerable) {
			this.steerable = steerable;
		}

		public Steerable GetSteerable() {
			return steerable;
		}

		public int[] GetStructure() {
			return structure;
		}

		public void SetStructure(int[] structure) {
			this.structure = structure;
		}

		public void SetId(int id) {
			this.id = id;
		}
	}

}
