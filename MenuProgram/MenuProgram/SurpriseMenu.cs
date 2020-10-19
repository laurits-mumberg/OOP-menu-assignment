using System;

namespace MenuProgram
{
    public class SurpriseMenu : Menu
    {

        private string[] ascii = new string[16];

        public SurpriseMenu() : base("Yep")
        {
            //dont judge
            ascii[0] = "...............…………………………._¸„„„„_";
            ascii[1] = "…………………….…………...„--~*'¯…….'\\";
            ascii[2] = "………….…………………… („-~~--„¸_….,/ì'Ì";
            ascii[3] = "…….…………………….¸„-^\"¯ : : : : :¸-¯\"¯/'";
            ascii[4] = "……………………¸„„-^\"¯ : : : : : : : '\\¸„„,-\"";
            ascii[5] = "**¯¯¯'^^~-„„„----~^*'\"¯ : : : : : : : : : :¸-\"";
            ascii[6] = ".:.:.:.:.„-^\" : : : : : : : : : : : : : : : : :„-\"";
            ascii[7] = ":.:.:.:.:.:.:.:.:.:.: : : : : : : : : : ¸„-^¯";
            ascii[8] = ".::.:.:.:.:.:.:.:. : : : : : : : ¸„„-^¯";
            ascii[9] = ":.' : : '\\ : : : : : : : ;¸„„-~\"";
            ascii[10] = ":.:.:: :\" -„\"\" * **/*'ì¸'¯";
            ascii[11] = ":.': : : : :\"-„ : : :\"\\";
            ascii[12] = ".:.:.: : : : :\" : : : : \\,";
            ascii[13] = ":.: : : : : : : : : : : : 'Ì";
            ascii[14] = ": : : : : : :, : : : : : :/";
            ascii[15] = "\"-„_::::_„-*__„„~\"";
        }

        

        public override void Select()
        {

            for (int i = 0; i < ascii.Length; i++)
            {
                MenuItems.Add(new MenuItem(ascii[i], "Nice cock"));
            }
            MenuItems.Add(new MenuItem("Cock drawing failed", "Har brugt for lang tid på at sætte det her lort ind til at jeg gider slette det"));
            Start();
        }
    }
}
