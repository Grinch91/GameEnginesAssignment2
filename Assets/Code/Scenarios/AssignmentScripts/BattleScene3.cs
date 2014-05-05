using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace BGE.Scenarios
{
	public class BattleScene3 : Scenario {

		public GameObject hleader;
		public GameObject hfLeader;
		public GameObject ofLeader;
		public GameObject g1Leader;
		public GameObject g2Leader;
		public GameObject g3Leader;
		public GameObject g4Leader;
		public GameObject g5Leader;
		public GameObject aLeader;
		public GameObject stargate;
		public GameObject camera;

		public GameObject oLeader;
		public GameObject o1Leader;
		public GameObject o2Leader;

		public Path path1;
		public Path path2;
		public Path path3;
		public Path path4;
		public Path path5;

		public Path path6;
		public Path path7;
		public Path path8;

		public override string Description()
		{
			return "fight";
		}
		
		public Vector3 initialPos = Vector3.zero;
		// Use this for initialization
		public override void Start () {
			stargate = CreateBoid(new Vector3(10,10,10),stargatePrefab);
			hleader = CreateBoid(new Vector3(0,30,200),humanleaderPrefab);
			hleader = CreateBoid(new Vector3(-15,30,210),humanleaderPrefab);
			
			g1Leader = CreateBoid(new Vector3(0,10,200),goauldleaderPrefab);
			g2Leader = CreateBoid(new Vector3(30,10,200),goauldleaderPrefab);
			g3Leader = CreateBoid(new Vector3(30,30,190),goauldleaderPrefab);
			g4Leader = CreateBoid(new Vector3(0,40,190),goauldleaderPrefab);
			g5Leader = CreateBoid(new Vector3(-25,20,200),goauldleaderPrefab);
			
			aLeader = CreateBoid(new Vector3(10,25,200),asgardPrefab);

			//Ori fleet creates
			oLeader = CreateBoid(new Vector3(20,20,10),orileaderPrefab);
			o1Leader = CreateBoid(new Vector3(0,20,30),orileaderPrefab);
			o2Leader = CreateBoid(new Vector3(-20,20,20),orileaderPrefab);
			
			#region goauld Ship paths
			initialPos = g1Leader.transform.position;
			path1 = g1Leader.GetComponent<SteeringBehaviours>().path;
			g1Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path1.Waypoints.Add(initialPos + new Vector3(0,0,-60));
			path1.Looped=false;
			path1.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g1Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g1Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			
			initialPos = g2Leader.transform.position;
			path2 = g2Leader.GetComponent<SteeringBehaviours>().path;
			g2Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path2.Waypoints.Add(initialPos + new Vector3(0,5,-50));
			path2.Looped=false;
			path2.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g2Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g2Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			
			initialPos = g3Leader.transform.position;
			path3 = g3Leader.GetComponent<SteeringBehaviours>().path;
			g3Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path3.Waypoints.Add(initialPos + new Vector3(0,-5,-20));
			path3.Looped=false;
			path3.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g3Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g3Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			
			initialPos = g4Leader.transform.position;
			path4 = g4Leader.GetComponent<SteeringBehaviours>().path;
			g4Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path4.Waypoints.Add(initialPos + new Vector3(0,0,-40));
			path4.Looped=false;
			path4.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g4Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g4Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;

			initialPos = g5Leader.transform.position;
			path5 = g5Leader.GetComponent<SteeringBehaviours>().path;
			g5Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path5.Waypoints.Add(initialPos + new Vector3(-15,0,-50));
			path5.Looped=false;
			path5.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			g5Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			g5Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			#endregion

			#region ori movemennts
			initialPos = oLeader.transform.position;
			path6 = oLeader.GetComponent<SteeringBehaviours>().path;
			oLeader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path6.Waypoints.Add(initialPos + new Vector3(0,0,100));
			path6.Looped=false;
			path6.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			oLeader.GetComponent<SteeringBehaviours>().TurnOffAll();
			oLeader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;

			initialPos = o1Leader.transform.position;
			path7 = o1Leader.GetComponent<SteeringBehaviours>().path;
			o1Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path7.Waypoints.Add(initialPos + new Vector3(0,0,100));
			path7.Looped=false;
			path7.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			o1Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			o1Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;

			initialPos = o2Leader.transform.position;
			path8 = o2Leader.GetComponent<SteeringBehaviours>().path;
			o2Leader.GetComponent<SteeringBehaviours>().path.Waypoints.Add(initialPos);
			path8.Waypoints.Add(initialPos + new Vector3(0,0,80));
			path8.Looped=false;
			path8.draw=false;
			Params.camMode = (Params.camMode + 1)%3;
			o2Leader.GetComponent<SteeringBehaviours>().TurnOffAll();
			o2Leader.GetComponent<SteeringBehaviours>().FollowPathEnabled = true;
			#endregion
		}
	}
}
