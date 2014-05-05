using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace BGE.Scenarios
{
	public class BattleScene2 : Scenario {

		public GameObject oLeader;
		public GameObject o1Leader;
		public GameObject o2Leader;
		public GameObject fighterLeader;
		public GameObject fighter;
		public GameObject stargate;
		public GameObject camera;
		public GameObject target;
		public Path path1;
		public Path path2;
		public Path path3;

		public Vector3 initialPos = Vector3.zero;

		public override string Description()
		{
			return "Battle Scene script";
		}

		// Use this for initialization
		public override void Start () {
			Params.Load("MyBattle.txt");
			stargate = CreateBoid(new Vector3(10,10,10),stargatePrefab);

			//Ori fleet creates
			oLeader = CreateBoid(new Vector3(-2,20,-30),orileaderPrefab);
			o1Leader = CreateBoid(new Vector3(-2,20,-60),orileaderPrefab);
			o2Leader = CreateBoid(new Vector3(-2,20,0),orileaderPrefab);

			fighterLeader = CreateBoid(new Vector3(-2,20,-80),oriFighterPrefab);
			fighterLeader.GetComponent<SteeringBehaviours>().ArriveEnabled = true;
			fighterLeader.GetComponent<SteeringBehaviours>().ObstacleAvoidanceEnabled = true;
			fighterLeader.GetComponent<SteeringBehaviours>().PlaneAvoidanceEnabled = true;
			fighterLeader.GetComponent<SteeringBehaviours>().seekTargetPos = new Vector3(-8,5,205);


			camera = GameObject.Find("MainCamera");
			camera.transform.position = new Vector3 (-25,27,16);
			//defining mother ship paths
			#region Ori Mother Ship paths
			initialPos = oLeader.transform.position;
			path1 = oLeader.GetComponent<SteeringBehaviours>().path;
			oLeader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path1.Waypoints.Add(initialPos + new Vector3(-8,5,65));
			path1.Waypoints.Add(initialPos + new Vector3(-8,5,205));
			path1.Looped=false;
			path1.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			oLeader.GetComponent<SteeringBehaviours>().TurnOffAll();
			oLeader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;

			initialPos = o1Leader.transform.position;
			path2 = o1Leader.GetComponent<SteeringBehaviours>().path;
			o1Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path2.Waypoints.Add(initialPos + new Vector3(-8,5,95));
			path2.Waypoints.Add(initialPos + new Vector3(-8,5,205));
			path2.Looped=false;
			path2.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			o1Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			o1Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;

			initialPos = o2Leader.transform.position;
			path3 = o2Leader.GetComponent<SteeringBehaviours>().path;
			o2Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path3.Waypoints.Add(initialPos + new Vector3(-8,5,95));
			path3.Waypoints.Add(initialPos + new Vector3(-8,5,205));
			path3.Looped=false;
			path3.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			o2Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			o2Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			#endregion
		}
		
		// Update is called once per frame
		void Update () {
		
		}
	}
}
