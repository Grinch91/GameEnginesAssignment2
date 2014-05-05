using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace BGE.Scenarios
{
	public class BattleScene7 : Scenario {

		public GameObject hLeader;

		public Path path;

		public override string Description()
		{
			return "end";
		}
		
		public Vector3 initialPos = Vector3.zero;
		// Use this for initialization
		public override void Start () {

			hLeader = CreateBoid(new Vector3(0,30,200),humanleaderPrefab);

			initialPos = hLeader.transform.position;			
			path = hLeader.GetComponent<SteeringBehaviours>().path;
			hLeader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path.Waypoints.Add(initialPos + new Vector3(0,0,-30));
			path.Waypoints.Add(initialPos + new Vector3(15,0,-40));
			path.Waypoints.Add(initialPos + new Vector3(40,0,-40));
			path.Looped=false;
			path.draw = false;
			hLeader.GetComponent<SteeringBehaviours>().TurnOffAll();
			hLeader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
		}
	}
}