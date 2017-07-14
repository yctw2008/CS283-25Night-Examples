using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class pokemon
    {
        static void Main(string[] args)
        {
            Pokemon aPokemon = new Pokemon()
            {
                 name = "妙蛙種子";
                 hp = "60/60";
                 gender = "男";
                 weight kg = "5.94";
                 type = "草/毒";
                 height m = "0.67";
                 Stardust = "271484";
                 Candy = "27";
                 strengthen = "3000, 3";
                 EVO = "25";
                 skill(1) = "藤編";
                 skill(01) = "7";
                 skill(2) = "汙泥炸彈";
                 skill(02) = "80";
             };
             Console.WriteLine(
                  "名稱:{0}, 強度:{1}, 性別:{2}, 體重:{3}, 屬性:{4}, 身高:{5}, 星星沙子:{6}, 妙娃種子的糖果:{7}, 強化:{8}{9}, 進化:{10}, 技能(01):{11}, 技能(02):{12}"
                 , aPokemon.name 
                 , aPokemon.hp 
                 , aPokemon.gender 
                 , aPokemon.weight 
                 , aPokemon.type 
                 , aPokemon.height 
                 , aPokemon.stardust 
                 , aPokemon.candy 
                 , aPokemon.strengthen 
                 , aPokemon.EVO 
                 , aPokemon.skill(1) 
                 , aPokemon.skill(01)
                 , aPokemon.skill(2) 
                 , aPokemon.skill(02)
             };




}
