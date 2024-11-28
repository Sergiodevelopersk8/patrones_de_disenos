using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploBuilder
{
    public interface IRobotBuilder
    {
        //Product Builder
        /*metodo para construir cabeza*/
        void BuildHead(String head);
        
        /*metodo para construir cuerpo*/
        void BuildBody(String body);
        
        /*metodo para construir cabeza*/
        void BuildArms(String arms);

        /*metodo para construir cabeza*/
        void BuildLegs(String legs);

        /*devuelve el robot de su clase*/
        Robot GetRobot();

    }
}
