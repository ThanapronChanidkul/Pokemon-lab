using Lab_Pokemon_dex.pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Pokemon_dex
{
    internal class Beedrill : Pokemon
    {
        public Beedrill() 
        {
            Random random = new Random();
            this.name = "Bulbasaur";
            //random number between >= 430 and < 525
            this.HP = random.Next(500, 1050);
            this._image = Properties.Resources._001;
            this.Attack = random.Next(166, 307);
            this.Defense = random.Next(10,50);
        }
    }
}
