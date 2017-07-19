using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Pokemon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pokemon aPokemon = new Pokemon()
            {
                Name = "妙蛙種子",
                CurrentHp = "60",
                Hp = "60"
                Gender = "男",
                Weight = "5.94",
                Types = "草/毒",
                Height = "0.67",
                UserStarDust = "271484",
                UserCandy = "27",
                PowerUpStardust = "3000",
                PowerUpCandy = "3",
                EvoCandy = "25",
                SkillVine = "7",
                SkillSludgeBomb = "80";
              }; 

            Console.WriteLine( 
            "Name:{1}
            ,CurrentHp:{2}
            ,Hp:{3}
            ,Gender:{4}
            ,Weight:{5}
            ,Types:{6}
            ,Height:{7}
            ,UserStarDust:{8}
            ,UserCandy:{9}
            ,PowerUpStardust:{10}
            ,PowerUpCandy:{11}
            ,EvoCandy:{12}
            ,SkillVine:{13}
            ,SkillSludgeBomb:{14}"
            ,aPokemon.Name
            ,aPokemon.CurrentHp
            ,aPokemon.Hp
            ,aPokemon.Gender
            ,aPokemon.Weight
            ,aPokemon.Types
            ,aPokemon.Height
            ,aPokemon.UserStarDust
            ,aPokemon.UserCandy
            ,aPokemon.PowerUpStardust
            ,aPokemon.PowerUpCandy
            ,aPokemon.EvoCandy
            ,aPokemon.SkillVine
            ,aPokemon.SkillSludgeBomb

            );

        }
}
