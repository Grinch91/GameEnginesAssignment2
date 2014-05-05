using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace BGE.Scenarios
{
	public class BattleScene5 : Scenario {

		
		public GameObject g1Leader;
		public GameObject g2Leader;
		public GameObject g3Leader;
		public GameObject g4Leader;

		public Path path1;
		public Path path2;
		public Path path3;
		public Path path4;

		public override string Description()
		{
			return "Battle Scene script";
		}
		
		public Vector3 initialPos = Vector3.zero;
		// Use this for initialization
		public override void Start () {

			g1Leader = CreateBoid(new Vector3(10,10,0),goauldleaderPrefab);
			g2Leader = CreateBoid(new Vector3(20,10,-10),goauldleaderPrefab);
			g3Leader = CreateBoid(new Vector3(0,10,-10),goauldleaderPrefab);
			g4Leader = CreateBoid(new Vector3(5,5,0),goauldleaderPrefab);

			#region goauld Ship paths
			initialPos = g1Leader.transform.position;
			path1 = g1Leader.GetComponent<SteeringBehaviours>().path;
			g1Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path1.Waypoints.Add(initialPos + new Vector3(0,0,100));
			path1.Looped=false;
			path1.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g1Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g1Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			
			initialPos = g2Leader.transform.position;
			path2 = g2Leader.GetComponent<SteeringBehaviours>().path;
			g2Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path2.Waypoints.Add(initialPos + new Vector3(0,0,100));
			path2.Looped=false;
			path2.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g2Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g2Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			
			initialPos = g3Leader.transform.position;
			path3 = g3Leader.GetComponent<SteeringBehaviours>().path;
			g3Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path3.Waypoints.Add(initialPos + new Vector3(0,0,100));
			path3.Looped=false;
			path3.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g3Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g3Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;

			initialPos = g4Leader.transform.position;
			path3 = g4Leader.GetComponent<SteeringBehaviours>().path;
			g4Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path3.Waypoints.Add(initialPos + new Vector3(0,0,100));
			path3.Looped=false;
			path3.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g4Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g4Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			#endregion
		}
	}
}