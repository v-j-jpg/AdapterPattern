///////////////////////////////////////////////////////////
//  Labud.cs
//  Implementation of the Class Labud
//  Generated by Enterprise Architect
//  Created on:      21-Apr-2020 11:56:26 AM
//  Original author: Lenovo
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using ZivotinjskoCarstvo;
namespace ZivotinjskoCarstvo {
	public class Labud : Ptice {

		public Labud(){

		}

		~Labud(){

		}

		public override void Leti()
		{
			Console.WriteLine("Labud leti"); 
		}

		public override void Pevaj()
		{
			Console.WriteLine("Labud peva");
		}
	}//end Labud

}//end namespace ZivotinjskoCarstvo