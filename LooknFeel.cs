using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;



namespace ProgPOE
{
    class LooknFeel
    {
        public void Audio()
        {
            SoundPlayer play = new SoundPlayer("./aud.wav");
            play.Play();

          
        }
        public void logo()
        {
            String logo = @"                                                     __
                              .__                         / |
                             /  /                         |  \
                            /   |                     ,-------'_
                       ____/     \_________,     ,_--""      _/  \_
         _______------'                     `---""          ,-\___/
     _--""                                               ,-""
 ___(___                                          ,__--""
(-------0       cybersecurity awareness     __---""
 `--___                                    /
       `--___\                _______-----'
             \\    (____-----'
              \\    \_
               `""`..__\";
            

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(logo);
            Console.WriteLine("--------------------------------------------------------");
            Console.ResetColor();

        }
       
            
            
        
    }
}
